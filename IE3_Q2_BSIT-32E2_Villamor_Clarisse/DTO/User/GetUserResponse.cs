namespace IE3_Q2_BSIT_32E2_Villamor_Clarisse.DTO.User

{
    public class GetUserResponse
    {
        public List<GetUserDto> Users { get; set; } 
        public int TotalCount => Users?.Count ?? 0;
    }

    public class GetUserDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
            
       public string Email { get; set; } = string.Empty;
    }
}
