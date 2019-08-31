﻿namespace BiliAccount
{
    public abstract class AbstractQRCode
    {
        #region Protected Constructors

        protected AbstractQRCode()
        {
        }

        protected AbstractQRCode(QRCodeData data)
        {
            this.QrCodeData = data;
        }

        #endregion Protected Constructors

        #region Protected Properties

        protected QRCodeData QrCodeData { get; set; }

        #endregion Protected Properties

        #region Public Methods

        public void Dispose()
        {
            this.QrCodeData = null;
        }

        /// <summary>
        /// Set a QRCodeData object that will be used to generate QR code. Used in COM Objects connections
        /// </summary>
        /// <param name="data">Need a QRCodeData object generated by QRCodeGenerator.CreateQrCode()</param>
        virtual public void SetQRCodeData(QRCodeData data)
        {
            this.QrCodeData = data;
        }

        #endregion Public Methods
    }
}