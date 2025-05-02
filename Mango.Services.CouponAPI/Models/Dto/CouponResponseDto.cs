namespace Mango.Services.CouponAPI.Models.Dto
{
    public class CouponResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
