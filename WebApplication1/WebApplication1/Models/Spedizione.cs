using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Spedizione
    {
        [DisplayName("Id Spedizione")]
        public int IdSpedizione { get; set; }
        [DisplayName("Id Cliente")]
        public int idCliente { get; set; }
        [DisplayName("Codice Tracciamento")]
        [Required(ErrorMessage = "Il codice è obbligatorio")]
        [StringLength(50)]
        public string CodTracciamento { get; set; }
        [DisplayName("Data Spedizione")]
        public DateTime DataSpedizione { get; set; }
        [DisplayName("Peso Spedizione in Kg")]
        [Required(ErrorMessage = "Il codice è obbligatorio")]
        public decimal PesoSpedizione { get; set; }
        [DisplayName("Città")]
        [Required(ErrorMessage = "la destinazione e' obbligatoria")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "la citta deve essere compresa tra 3 e 50 caratteri")]
        public string CittaDestinazione { get; set; }
        [DisplayName("Indirizzo")]
        [Required(ErrorMessage = "l'indirizzo di destinazione e' obbligatorio")]
        public string IndirizzoDestinazione { get; set; }
        [DisplayName("Nominativo")]
        [Required(ErrorMessage = "Il nominativo del destinatario e' obbligatorio")]
        public string NominativoDestinatario { get; set; }
        [DisplayName("Costo in €")]
        [Required(ErrorMessage = "Il costo della spedizione e' obbligatorio")]
        public decimal CostoSpedizione { get; set; }
        [DisplayName("Data Consegna")]
        public DateTime DataConsegna { get; set; }
    }
}