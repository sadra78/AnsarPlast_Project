using _0_Framework.Domain;

namespace ShopManagement.Domain.BannerAgg
{
    public class Banner : EntityBase
    {
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public string BtnText { get; private set; }
        public string Link { get; private set; }
        public bool IsRemoved { get; private set; }

        public Banner(string picture, string pictureAlt, string pictureTitle, string title, string text, string btnText, string link)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Title = title;
            Text = text;
            BtnText = btnText;
            Link = link;
            IsRemoved = false;
        }

        public void Edit(string picture, string pictureAlt, string pictureTitle, string title, string text, string btnText, string link)
        {
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Title = title;
            Text = text;
            BtnText = btnText;
            Link = link;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}