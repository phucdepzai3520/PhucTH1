using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace TH01.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string? MenuName { get; set }
        public bool? IsActive { get; set }
        public string? ControllerName { get; set }
        public string? ActionName { get; set }
        public int Levels { get; set  }
        public int ParentID { get; set }
        public string? Link { get; set }
        public int NewOder { get; set }
        public int Position { get; set }
   }
