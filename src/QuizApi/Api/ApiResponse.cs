namespace QuizApi.Api
{
    public class ApiResponse<T>
    {
        public string Message { get; set; }
        public bool Succeed { get; set; }
        public T Results { get; set; }
    }
}
