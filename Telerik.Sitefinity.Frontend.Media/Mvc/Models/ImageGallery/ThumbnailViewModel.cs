﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity.Frontend.Mvc.Models;
using Telerik.Sitefinity.Model;

namespace Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery
{
    /// <inheritdoc />
    public class ThumbnailViewModel : ItemViewModel
    {
        /// <inheritdoc />
        public ThumbnailViewModel(IDataItem item) : base(item)
        {
        }

        /// <summary>
        /// Gets or sets the thumbnail URL of the item.
        /// </summary>
        /// <value>The thumbnail URL.</value>
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets the URL of the image.
        /// </summary>
        /// <value>The image URL.</value>
        public string MediaUrl { get; set; }

        /// <summary>
        /// Gets or sets the width of the image.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the image.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the width of the details image.
        /// </summary>
        public int? DetailsImageWidth { get; set; }

        /// <summary>
        /// Gets or sets the height of the details image.
        /// </summary>
        public int? DetailsImageHeight { get; set; }
    }
}
