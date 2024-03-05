using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using WebApplication1;


namespace WebApplication1.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Id Cliente")]
        public int idCliente {  get; set; }
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public string Nominativo { get; set; }
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public bool IsAzienda { get; set; }
        
        [Display(Name = "Codice Fiscale")]
        
        public string codiceFiscale { get; set; }
        
        [Display(Name = "Partita Iva")]
        public string partitaIva {  get; set; }
    }
}