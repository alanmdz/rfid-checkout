﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;


namespace RFIDtoCS
{
    using  DL_STATUS=System.UInt32;
    
    public enum ERRORCODES 
    {

        DL_OK                                   = 0x00,
        COMMUNICATION_ERROR                     = 0x01,
        CHKSUM_ERROR                            = 0x02,
        READING_ERROR                           = 0x03,
        WRITING_ERROR                           = 0x04,
        BUFFER_OVERFLOW                         = 0x05,
        MAX_ADDRESS_EXCEEDED                    = 0x06,
        MAX_KEY_INDEX_EXCEEDED                  = 0x07,
        NO_CARD                                 = 0x08,
        COMMAND_NOT_SUPPORTED                   = 0x09,
        FORBIDEN_DIRECT_WRITE_IN_SECTOR_TRAILER = 0x0A,
        ADDRESSED_BLOCK_IS_NOT_SECTOR_TRAILER   = 0x0B,
        WRONG_ADDRESS_MODE                      = 0x0C,
        WRONG_ACCESS_BITS_VALUES                = 0x0D,
        AUTH_ERROR                              = 0x0E,
        PARAMETERS_ERROR                        = 0x0F,
        MAX_SIZE_EXCEEDED                       = 0x10,
        UNSUPPORTED_CARD_TYPE                   = 0x11,

        COMMUNICATION_BREAK                     = 0x50,
        NO_MEMORY_ERROR                         = 0x51,
        CAN_NOT_OPEN_READER                     = 0x52,
        READER_NOT_SUPPORTED                    = 0x53,
        READER_OPENING_ERROR                    = 0x54,
        READER_PORT_NOT_OPENED                  = 0x55,
        CANT_CLOSE_READER_PORT                  = 0x56,

        WRITE_VERIFICATION_ERROR                = 0x70,
        BUFFER_SIZE_EXCEEDED                    = 0x71,
        VALUE_BLOCK_INVALID                     = 0x72,
        VALUE_BLOCK_ADDR_INVALID                = 0x73,
        VALUE_BLOCK_MANIPULATION_ERROR          = 0x74,
        WRONG_UI_MODE                           = 0x75,
        KEYS_LOCKED                             = 0x76,
        KEYS_UNLOCKED                           = 0x77,
        WRONG_PASSWORD                          = 0x78,
        CAN_NOT_LOCK_DEVICE                     = 0x79,
        CAN_NOT_UNLOCK_DEVICE                   = 0x7A,
        DEVICE_EEPROM_BUSY                      = 0x7B,
        RTC_SET_ERROR                           = 0x7C,
        ANTICOLLISION_DISABLED                  = 0x7D,
        NO_CARDS_ENUMERRATED                    = 0x7E,
        CARD_ALREADY_SELECTED                   = 0x7F,

        FT_STATUS_ERROR_1                       = 0xA0,
        FT_STATUS_ERROR_2                       = 0xA1,
        FT_STATUS_ERROR_3                       = 0xA2,
        FT_STATUS_ERROR_4                       = 0xA3,
        FT_STATUS_ERROR_5                       = 0xA4,
        FT_STATUS_ERROR_6                       = 0xA5,
        FT_STATUS_ERROR_7                       = 0xA6,
        FT_STATUS_ERROR_8                       = 0xA7,
        FT_STATUS_ERROR_9                       = 0xA8 
    
    }



    unsafe class uFRCoder1x
    {
        [DllImport("uFCoder1x.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ReaderOpen")]
        public static extern DL_STATUS ReaderOpen();

        [DllImport("uFCoder1x.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ReaderClose")]
        public static extern DL_STATUS ReaderClose();

        [DllImport("uFCoder1x.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetReaderType")]
        public static extern DL_STATUS GetReaderType(ulong* get_reader_type);

        

        [DllImport("uFCoder1x.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetCardIdEx")]
        public static extern DL_STATUS GetCardIdEx(byte* bCardType,
                                                   byte* bCardUID,
                                                   byte* bUidSize);

        [DllImport("uFCoder1x.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "GetDlogicCardType")]
        public static extern DL_STATUS GetDlogicCardType(byte* bCardType);

        [DllImport("uFCoder1x.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "ReaderUISignal")]
        public static extern DL_STATUS ReaderUISignal(int light_mode, 
                                                      int sound_mode);

        [DllImport("uFCoder1x.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearRead")]
        public static extern DL_STATUS LinearRead(byte* aucData,
                                                   int linear_address,
                                                   int data_len,
                                                   int* bytes_written,
                                                   byte key_mode,
                                                   byte key_index);

        [DllImport("uFCoder1x.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "LinearWrite")]
        public static extern DL_STATUS LinearWrite(byte* aucData,
                                                   ushort linear_address,
                                                   ushort data_len,
                                                   ushort* bytes_written,
                                                   byte auth_mode,
                                                   byte key_index);
      
       
       

        [DllImport("uFCoder1x.dll",CallingConvention=CallingConvention.StdCall,CharSet=CharSet.Auto,EntryPoint="BlockWrite")]
        public static extern DL_STATUS BlockWrite(byte* bFormatData,
                                                  short shBlockAddress,
                                                  byte bAuthMode,
                                                  byte bKeyIndex);
    }
}
