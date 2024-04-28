using Microsoft.AspNetCore.Http.Features;

namespace FileUpload.MVC.Middlewares
{
    public class DynamicRequestBodySizeMiddleware
    {
        private readonly RequestDelegate _next;

        public DynamicRequestBodySizeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (IsSpecificURL(context.Request.Path))
            {
                var formOptions = new FormOptions
                {
                    MultipartBodyLengthLimit = long.MaxValue // Set the desired limit here for the specific URL
                };

                context.Request.HttpContext.Features.Set<IFormFeature>(new FormFeature(context.Request, formOptions));
            }

            await _next(context);
        }

        private bool IsSpecificURL(PathString path)
        {
            // Define the logic to identify the specific URL
            // For example:
            return path.StartsWithSegments("/File/UploadToFileSystem");
        }
    }

}
