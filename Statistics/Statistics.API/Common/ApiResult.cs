namespace Statistics.API.Common
{
    public class ApiResult<T>
    {
        public int Code { get; set; }
        public T Data { get; set; }

        public ApiResult(int code, T data)
        {
            Code = code;
            Data = data;
        }

        public static ApiResult<T> OK(T data) =>
            new(0, data);
    }
}
