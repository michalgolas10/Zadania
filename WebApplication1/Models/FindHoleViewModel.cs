using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Utility;
using Xunit;

namespace ZadaniaRekrutacyjne.Models
{
    public class FindHoleViewModel
    {
        [Range(1,100,ErrorMessage="Liczba kolumn nie może być mniejsza od 1")]
        public int MatrixColumns { get; set; }
        [Range(1, 100, ErrorMessage = "Liczba wierszy nie może być mniejsza od 1")]
        public int MatrixRows { get; set; }
    }
}
