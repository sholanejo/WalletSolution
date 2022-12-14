using System.ComponentModel.DataAnnotations.Schema;

namespace WalletSolution.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime DateOfTransaction { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string TransactionType { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PreviousBalance { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CurrentBalance { get; set; }
        public string AccountType { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }
    }
}
