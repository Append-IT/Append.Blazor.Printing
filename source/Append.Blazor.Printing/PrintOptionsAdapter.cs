using System;

namespace Append.Blazor.Printing
{
    /// <summary>
    /// Adapts the <see cref="PrintOptions"/> to the JavaScript version.
    /// </summary>
    internal record PrintOptionsAdapter
    {
        public string Printable { get; init; }
        public string Type { get; init; }
        public string DocumentTitle { get; set; } = "Document";
        public bool ShowModal { get; init; }
        public string ModalMessage { get; init; } = "Retrieving Document...";
        public bool? Base64 { get; set; }
        public string TargetStyles { get; set; } = "['*']";

        public PrintOptionsAdapter(PrintOptions options)
        {
            Printable = options.Printable;
            Type = options.Type.ToPrintJsString();
            if (!string.IsNullOrWhiteSpace(options.DocumentTitle))
                DocumentTitle = options.DocumentTitle;
            ShowModal = options.ShowModal;
            ModalMessage = options.ModalMessage;
            Base64 = options.Base64 == true ? true : null;
        }
    }
}
