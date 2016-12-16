using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RFIDtoCS
{
    using  DL_STATUS=System.UInt32;
    public partial class RFIDtoCS : Form
    {
        public RFIDtoCS()
        {
            InitializeComponent();
        }

   //DLOGIC CARD TYPE
const byte DL_MIFARE_ULTRALIGHT		      =	 0x01,
           DL_MIFARE_ULTRALIGHT_EV1_11	  =	 0x02,
           DL_MIFARE_ULTRALIGHT_EV1_21	  =	 0x03,
           DL_MIFARE_ULTRALIGHT_C		  =	 0x04,
           DL_NTAG_203				      =  0x05,
           DL_NTAG_210				      =  0x06,
           DL_NTAG_212				      =  0x07,
           DL_NTAG_213				      =  0x08,
           DL_NTAG_215				      =  0x09,
           DL_NTAG_216				      =  0x0A,
           DL_MIFARE_MINI				  =  0x20,
           DL_MIFARE_CLASSIC_1K			  =  0x21,
           DL_MIFARE_CLASSIC_4K			  =  0x22,
           DL_MIFARE_PLUS_S_2K			  =  0x23,
           DL_MIFARE_PLUS_S_4K			  =  0x24,
           DL_MIFARE_PLUS_X_2K			  =  0x25,
           DL_MIFARE_PLUS_X_4K			  =  0x26,
           DL_MIFARE_DESFIRE			  =  0x27,
           DL_MIFARE_DESFIRE_EV1_2K		  =  0x28,
           DL_MIFARE_DESFIRE_EV1_4K		  =  0x29,
           DL_MIFARE_DESFIRE_EV1_8K		  =  0x2A;

  

   //authenticate
  const byte  MIFARE_AUTHENT1A  = 0x60,
              MIFARE_AUTHENT1B  = 0x61;       
 
  const byte  DL_OK             = 0,
              KEY_INDEX         = 0;
  
  //for result                    
  const byte  FRES_OK_LIGHT     = 4,
              FRES_OK_SOUND     = 0,
              FERR_LIGHT        = 2,
              FERR_SOUND        = 0;

  // sectors and bytes
  const byte 
             MAX_SECTORS_1k         = 16,
             MAX_SECTORS_4k         = 40,            
             MAX_BYTES_NTAG_203     = 144,
             MAX_BYTES_ULTRALIGHT   =  48,
             MAX_BYTES_ULTRALIGHT_C = 144;
  const short
             MAX_BYTES_CLASSIC_1K   = 752,
             MAX_BYTES_CLASSIC_4k   = 3440;
             
  const byte           
             MAX_BLOCK          = 16,
             FORMAT_SIGN        = 0xFF;

        private Boolean boCONN        = false,  
                        boThreadStart = false,
                        boFunctionOn  = false;


        private byte bTypeOfCard = 0;                     
        private string[] ERROR_CODES;
        
        void SetStatusBar(DL_STATUS result, System.Windows.Forms.StatusStrip stbStatusBar)
        {            
            stbStatusBar.Items[1].Text = "0x" + result.ToString("X2");
            stbStatusBar.Items[2].Text = ERROR_CODES[result];
        }
      
        private Boolean SetFunctionStatus
        {
          get{
            return boFunctionOn;
          }
          set{
            boFunctionOn=value;
          }
        }

        private Boolean LoopStart
        {
          get{
              return boThreadStart;
          }
          set{
              boThreadStart=value;
          }
        }

        //max blocks in card
        private int MaxBlocks(byte bTypeCard){
            int iResult=0;
          switch (bTypeCard)
          {
              case DL_MIFARE_CLASSIC_1K : iResult = MAX_SECTORS_1k * 4;
                   break;
              case DL_MIFARE_CLASSIC_4K :
              case DL_MIFARE_PLUS_S_4K: iResult = ((MAX_SECTORS_1k * 2) * 4) + ((MAX_SECTORS_1k - 8) * 16);
                   break;
          }
          return iResult;
       }

       //max bytes of card
        private int MaxBytes(byte bCardType)
        {
          short usMaxBytes = 0;
          switch(bCardType)
          {
             case DL_NTAG_203           : usMaxBytes = MAX_BYTES_NTAG_203;
                 break;
             case DL_MIFARE_ULTRALIGHT  : usMaxBytes = MAX_BYTES_ULTRALIGHT;
                 break;
             case DL_MIFARE_ULTRALIGHT_C: usMaxBytes = MAX_BYTES_ULTRALIGHT_C;
                 break;
             case DL_MIFARE_CLASSIC_1K  : usMaxBytes = MAX_BYTES_CLASSIC_1K;
                 break;
             case DL_MIFARE_CLASSIC_4K  :
             case DL_MIFARE_PLUS_S_4K   : usMaxBytes = MAX_BYTES_CLASSIC_4k;
                  break;
           }
          return usMaxBytes;
        }

        private void mnuExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainThread()
        {
            ulong ulReaderType = 0;                 
            byte bUidSize      = 0,
                 bDLCardType   = 0,
                 bCardType     = 0; 
            byte [] baCardUID  = new byte[9];
            String sBuffer     = null;
            DL_STATUS iRResult,
                      iCResult;

            LoopStart =true;           
            if (!boCONN)
            {
                if ((iRResult = uFRCoder1x.ReaderOpen()) == DL_OK)
                {
                    pnlConnected.Text = "CONNECTED";
                    boCONN = true;
                    SetStatusBar(iRResult, stbConnected);
                }
                else
                {
                    pnlConnected.Text = "NOT CONNECTED";
                    txtCardUID   .Clear();                    
                    SetStatusBar(iRResult, stbConnected);
                }
            }

            if (boCONN)
            {
                unsafe
                {
                    
                    fixed (byte* pData = baCardUID) 
                    if ((iRResult = uFRCoder1x.GetReaderType(&ulReaderType)) == DL_OK)
                    {
                        iCResult = uFRCoder1x.GetDlogicCardType(&bDLCardType);
                        if (iCResult == DL_OK)
                        {
                            iCResult = uFRCoder1x.GetCardIdEx(&bCardType,pData, &bUidSize);
                            if (iCResult == DL_OK)
                            {
                                   for (byte bCounter = 0; bCounter < bUidSize; bCounter++)
                                   {
                                       sBuffer += baCardUID[bCounter].ToString("X2");
                                   }
                            }                                                                          
                              txtCardUID.Text    = "0x" +sBuffer;                                                                                           
                              bTypeOfCard=bDLCardType;
                              SetStatusBar(iCResult, stbCardStatus);
                        }
                        else
                        {
                            
                            txtCardUID   .Clear();                          
                            SetStatusBar(iCResult, stbCardStatus);
                        }                       
                    }
                    else
                    {                        
                        boCONN = false;
                        uFRCoder1x.ReaderClose();
                        txtCardUID   .Clear();                        
                    }
                }

            }
            LoopStart =false;
        }
      
      
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!SetFunctionStatus)
                MainThread();
        }

       

        private void btnFormatCard_Click(object sender, EventArgs e)
        {
           if (SetFunctionStatus  || LoopStart ) return;
           try
           {
               SetFunctionStatus =true;               
               DL_STATUS iFResult   = 0;
               byte[]baFormatArray  = Enumerable.Repeat(FORMAT_SIGN, MAX_BLOCK).ToArray(); //fill array for format card
               short shBISCount     = 0;
               short shBlockCount   = 0;
               byte  bSectorCounter = 0;
               byte  bBISCounter    = 3;
               int   iMaxBlock      = MaxBlocks(bTypeOfCard);
               
               pBar.Maximum=iMaxBlock;
               pBar.Visible=true;
                
               
               while(shBlockCount<iMaxBlock)
               {
                 shBISCount=0;
                  while (shBISCount<bBISCounter)
                   {
                     unsafe
                     {
                       fixed(byte* pData=baFormatArray)
                       iFResult=uFRCoder1x.BlockWrite(pData,shBlockCount,MIFARE_AUTHENT1A,KEY_INDEX);
                     }                                                                                              
                        shBISCount++;
                        shBlockCount++;
                   }
                   shBlockCount++;
                   pBar.Value=shBlockCount;

                   if (bSectorCounter >= 31 && shBlockCount % 16 == 0)
                   {
                       bSectorCounter++;
                       bBISCounter = 15;
                   }
                   else
                       bSectorCounter++;
               }
               if (iFResult == DL_OK)
               {
                   SetStatusBar(iFResult, stbFunctionError);
                   uFRCoder1x.ReaderUISignal(FRES_OK_LIGHT, FRES_OK_SOUND);
               }
               else
               {
                   SetStatusBar(iFResult, stbFunctionError);
                   uFRCoder1x.ReaderUISignal(FERR_LIGHT, FERR_SOUND);
               }  
           }finally{
               SetFunctionStatus=false;
               pBar.Visible=false;
           }   
        }

          
       private void frmuFRSimplest_Load(object sender, EventArgs e)
       {
         int[]iErrorValues=(int[])Enum.GetValues(typeof(ERRORCODES));
         string[]sErrorNames=Enum.GetNames(typeof(ERRORCODES));
         
         ERROR_CODES=new string[iErrorValues.Max()+1];
         for (int i=0;i<iErrorValues.Length;i++)                          
              ERROR_CODES[iErrorValues[i]]=sErrorNames[i];                                                                                  
       }

       private void btnLinearRead_Click(object sender, EventArgs e)
       {
           if (SetFunctionStatus  || LoopStart ) return;
           try
           {
               SetFunctionStatus=true;
               int uiDataLength = MaxBytes(bTypeOfCard);
               int uiLinearAddress = 0;
               int uiBytesRet = 0;
               DL_STATUS iFResult;
               byte[] baReadData = new byte[uiDataLength];
               unsafe
               {
                   fixed (byte* PData = baReadData)
                       iFResult = uFRCoder1x.LinearRead(PData, uiLinearAddress, uiDataLength, &uiBytesRet, MIFARE_AUTHENT1A, KEY_INDEX);
               }
               if (iFResult == DL_OK)
               {
                   txtReadData.Text = System.Text.Encoding.ASCII.GetString(baReadData);
                   SetStatusBar(iFResult, stbFunctionError);
                   uFRCoder1x.ReaderUISignal(FRES_OK_LIGHT, FRES_OK_SOUND);
               }
               else
               {
                   SetStatusBar(iFResult, stbFunctionError);
                   uFRCoder1x.ReaderUISignal(FERR_LIGHT, FERR_SOUND);
               }
           }
           finally
           {
               SetFunctionStatus=false;
           }
       }

       private void lblReadData_Click(object sender, EventArgs e)
       {

       }     
    }
}
