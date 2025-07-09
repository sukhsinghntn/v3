namespace DynamicFormsApp.Shared.Models
{
    public class DeletedFormInfo
    {
        public string Message { get; set; } = "This form is no longer available. Please contact the owner.";
        public string? CreatedBy { get; set; }
        public string? OwnerEmail { get; set; }
        public string? OwnerName { get; set; }
    }
}
