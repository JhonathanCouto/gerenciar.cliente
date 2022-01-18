using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoCliente.API.Models
{
    public class CepModel
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("ibge")]
        public string Ibge { get; set; }

        [JsonProperty("gia")]
        public string Gia { get; set; }

        [JsonProperty("ddd")]
        public string Ddd { get; set; }

        [JsonProperty("siafi")]
        public string Siafi { get; set; }
    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class xmlcep
    {
        /// <remarks/>
        public string cep { get; set; }

        /// <remarks/>
        public string logradouro { get; set; }

        /// <remarks/>
        public string complemento { get; set; }

        /// <remarks/>
        public string bairro { get; set; }

        /// <remarks/>
        public string localidade { get; set; }

        /// <remarks/>
        public string uf { get; set; }

        /// <remarks/>
        public uint ibge { get; set; }

        /// <remarks/>
        public ushort gia { get; set; }

        /// <remarks/>
        public byte ddd { get; set; }

        /// <remarks/>
        public ushort siafi { get; set; }
    }
}
