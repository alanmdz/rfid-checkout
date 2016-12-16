# rfid-checkout

RFID Checkout software Implemented in C# and SQL. Uses the RFID reader from D-Logic (NFC RFID Manufacturer)
model type: uFR CLASSIC NFC RFID reader.

Matches the tag ID of a RFID tag to an item inside the database by having the
user scanning an item through the RFID reader. Then it adds up a total of the items
that will be purchased. A simple budgeting tool is also provided in case that the user
is under a budget. The tool will calculate what the max amount of items the user can take
while still maintaining the total within the budget.
