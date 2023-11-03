using DTOs.MaterialDTOs;

namespace DTOs.GoodDTOs
{
    public class GoodDTO : ShortGoodDTO
    {
        public List<MaterialDTO>? Material { get; set; }
    }
}
