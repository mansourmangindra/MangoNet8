using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace Mango.Services.OrderAPI.Models.Dto
{
    public class OrderResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
