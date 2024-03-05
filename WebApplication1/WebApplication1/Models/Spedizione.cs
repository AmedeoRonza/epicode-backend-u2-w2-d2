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
        public int IdSpedizione { get; set; }
        public int IdCliente { get; set; }
        [DisplayName("Crea codice tracciamento")]
        [Required(ErrorMessage = "Il codice è obbligatorio")]
        [StringLength(50)]
        public string codTracciamento { get; set; }
        public DateTime dataSpedizione { get; set; }
        [DisplayName("Inserisci il peso della spedizione")]
        [Required(ErrorMessage = "Il codice è obbligatorio")]
        public decimal pesoSpedizione { get; set; }
        [DisplayName("Inserisci la citta di destinazione")]
        [Required(ErrorMessage = "la destinazione e' obbligatoria")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "la citta deve essere compresa tra 3 e 50 caratteri")]
        public string cittaDestinazione { get; set; }
        [DisplayName("Inserisci l'indirizzo di destinazione")]
        [Required(ErrorMessage = "l'indirizzo di destinazione e' obbligatorio")]
        public string indirizzoDestinazione { get; set; }
        [DisplayName("Inserisci il nominativo del destinatario")]
        [Required(ErrorMessage = "Il nominativo del destinatario e' obbligatorio")]
        public string nominativoDestinatario { get; set; }
        [DisplayName("Inserisci il costo della spedizione")]
        [Required(ErrorMessage = "Il costo della spedizione e' obbligatorio")]
        public decimal costoSpedizione { get; set; }
        public DateTime dataConsegna { get; set; }
    }
}