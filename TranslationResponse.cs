using System.Collections.Generic;

namespace CizioApp
{
    public class TranslationResponse
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public List<Translation> translations { get; set; }
    }

    public class Translation
    {
        public string translatedText { get; set; }
    }
}
