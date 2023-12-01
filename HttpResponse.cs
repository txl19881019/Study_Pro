namespace WindowsFormsApp1
{
    public class HttpResponse<T>
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public T Data { get; set; }

        public static HttpResponse<T> Success(T data)
        {
            HttpResponse<T> result = new HttpResponse<T>();
            result.Data = data;
            result.Code = 200;
            result.Msg = "成功";
            return result;
        }

        public static HttpResponse<T> Failure(string msg)
        {
            HttpResponse<T> result = new HttpResponse<T>();
            result.Code = 500;
            result.Msg = msg;
            return result;
        }
    }
}
