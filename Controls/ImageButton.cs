namespace SilverlightImageButton.Controls
{
    using System.IO;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media.Imaging;

    [TemplatePart(Name = "PART_Image", Type = typeof(Image))]
    public class ImageButton : Button
    {
        public Image PartImage;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageButton" /> class.
        /// </summary>
        public ImageButton()
        {
            this.DefaultStyleKey = typeof(ImageButton);
        }

        /// <summary>
        /// Builds the visual tree for the <see cref="T:System.Windows.Controls.Slider" /> control when a new template is applied.
        /// </summary>
        public override void OnApplyTemplate()
        {
            this.PartImage = this.GetTemplateChild("PART_Image") as Image;

            if (this.PartImage != null)
            {
                //this.PartImage.MouseLeftButtonDown += this.PartImageOnMouseLeftButtonDown;
                //this.PartImage.MouseLeftButtonUp += this.PartImageOnMouseLeftButtonUp;

                this.SetImageSource(OffImageSource);
            }
        }

        #region Dependency properties

        /// <summary>
        /// Gets or sets the off image source.
        /// </summary>
        /// <value>
        /// An image source from Resources.ImageLibrary
        /// </value>
        public byte[] OffImageSource
        {
            get
            {
                return (byte[])this.GetValue(OffImageProperty);
            }
            set
            {
                this.SetValue(OffImageProperty, value);
            }
        }

        public static DependencyProperty OffImageProperty = DependencyProperty.Register(
            "OffImageSource", typeof(byte[]), typeof(ImageButton), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the on image source.
        /// </summary>
        /// <value>
        /// An image source from Resources.ImageLibrary
        /// </value>
        public byte[] OnImageSource
        {
            get
            {
                return (byte[])this.GetValue(OnImageProperty);
            }
            set
            {
                this.SetValue(OnImageProperty, value);
            }
        }

        public static DependencyProperty OnImageProperty = DependencyProperty.Register(
            "OnImageSource", typeof(byte[]), typeof(ImageButton), new PropertyMetadata(null));

        #endregion

        #region Button events

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            if (this.PartImage != null)
            {
                this.SetImageSource(OnImageSource);
            }
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);

            if (this.PartImage != null)
            {
                this.SetImageSource(OffImageSource);
            }
        }

        #endregion

        /// <summary>
        /// Sets the image source.
        /// </summary>
        /// <param name="imageSource">The lang en image.</param>
        private void SetImageSource(byte[] imageSource)
        {
            using (var ms = new MemoryStream(imageSource, 0, imageSource.Length - 1))
            {
                var bi = new BitmapImage();
                bi.SetSource(ms);

                this.PartImage.Source = bi;
            }
        }
    }
}
