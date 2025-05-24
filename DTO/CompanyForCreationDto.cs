namespace DemoModel.DTO
{
    public class CompanyForCreationDto : CompanyForManipulationDto 
    {
        public IEnumerable<CompanyForCreationDto> Employees { get; set; }
    }
}
