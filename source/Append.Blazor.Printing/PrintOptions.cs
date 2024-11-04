namespace Append.Blazor.Printing
{
    /// <summary>
    /// Options for a specific print.
    /// </summary>
    public record PrintOptions
    {
        public PrintOptions()
        {

        }
        public PrintOptions(string printable)
        {
            Printable = printable;
        }

        public PrintOptions(string printable, string modalMessage, PrintType printType = PrintType.Pdf)
        {
            Printable = printable;
            ModalMessage = modalMessage;
            ShowModal = true;
            Type = printType;
        }
        /// <summary>
        /// Document source: pdf url or base64.
        /// </summary>
        public string Printable { get; init; }
        /// <summary>
        /// Printable type.
        /// </summary>
        public PrintType Type { get; init; }
        /// <summary>
        /// When printing html, image or json, this will be shown as the document title.
        /// </summary>
        public string DocumentTitle { get; set; } = "Document";
        /// <summary>
        /// Enable this option to show user feedback when retrieving or processing large PDF files.
        /// </summary>
        public bool ShowModal { get; init; }
        /// <summary>
        /// Message displayed to users when <see cref="ShowModal"/> is set to true.
        /// </summary>
        public string ModalMessage { get; init; } = "Retrieving Document...";
        /// <summary>
        /// Used when printing PDF documents passed as base64 data.
        /// </summary>
        public bool Base64 { get; set; }
    }
}
