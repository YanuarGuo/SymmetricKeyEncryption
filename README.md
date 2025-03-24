# Symmetric Key Encryption

A Windows Forms application for symmetric key encryption and decryption using DES, TDES, and AES algorithms.

## Features
- Supports DES, TDES (112-bit & 168-bit), and AES (128-bit, 192-bit, 256-bit) encryption.
- Configurable encryption modes (ECB, CBC, etc.) and padding schemes.
- Supports both HEX and string representations for keys and IVs.
- User-friendly Windows Forms interface.
- Hashing support for keys to match required key sizes.
- Clear and reset functionality for easy testing.

## Technologies Used
- **C#** (.NET Framework)
- **Windows Forms (WinForms)**
- **AESLib, DESLib, TDESLib** DLLs for cryptographic operations.
- **PC/SC API** (if used for smart card integration in the future).

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/YanuarGuo/SymmetricKeyEncryption.git
   ```
2. Open the project in Visual Studio.
3. Ensure the required DLLs (**AESLib.dll, DESLib.dll, TDESLib.dll**) are present in the project directory.
4. Build the solution and run the application.

## Usage
1. Select the encryption type (DES, TDES, AES).
2. Configure key, IV, mode, padding, and key size (if applicable).
3. Enter the plaintext message for encryption.
4. Encrypt the message and copy the ciphertext.
5. Decrypt the ciphertext back to plaintext.

## Future Improvements
- Add smart card integration for key storage.
- Support for additional encryption modes.
- Improve UI/UX with modern design.
- Implement logging and error handling improvements.

## Author
Developed by Yanuar Christy Ade Utama.
