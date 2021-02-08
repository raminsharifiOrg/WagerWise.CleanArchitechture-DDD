﻿namespace BettingSystem.Web.ModelBinders
{
    using Application.Common.Images;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class ImageFormFileModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
            => context.Metadata.ModelType == typeof(ImageRequestModel)
                ? new ImageFormFileModelBinder()
                : default;
    }
}
