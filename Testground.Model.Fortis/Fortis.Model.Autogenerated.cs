using Sitecore.Data.Items;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Common;

#region Custom Item Wrapper (Extendable base class)

namespace Testground.Model.Fortis
{
	using System;
	using System.Collections.Generic;
	using global::Fortis.Model;
	using global::Fortis.Providers;

	/*
		To extend base ItemWrapper class and its interface, 
		create partial class CustomItemWrapper and interface ICustomItemWrapper
		in your model project and add required properties or methods there.
	*/
	public partial interface ICustomItemWrapper : IItemWrapper
	{
	}

	public partial class CustomItemWrapper : ItemWrapper, ICustomItemWrapper
	{
		public CustomItemWrapper(ISpawnProvider spawnProvider) 
			: base(spawnProvider)
		{
		}

		public CustomItemWrapper(Item item, ISpawnProvider spawnProvider) 
			: base(item, spawnProvider)
		{
		}

		public CustomItemWrapper(Guid id, ISpawnProvider spawnProvider) 
			: base(id, spawnProvider)
		{
		}

		public CustomItemWrapper(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) 
			: base(id, lazyFields, spawnProvider)
		{
		}
	}
}

#endregion

#region Title Field (UserDefined)

namespace Testground.Model.Fortis.Templates.UserDefined
{
	using System;
	using System.Collections.Generic;
	using global::Fortis.Model;
	using global::Fortis.Model.Fields;
	using global::Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Title Field</para>
	/// <para>ID: {352C79B1-B75C-4918-9B5F-FEE4BFFA5642}</para>
	/// <para>/sitecore/templates/User Defined/Data/Title Field</para>
	/// </summary>
	[TemplateMapping(TitleFieldItem.Constants.TemplateIdStr, "InterfaceMap")]
	public partial interface ITitleFieldItem : ICustomItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Title Field</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(TitleFieldItem.IndexFieldNames.ContentTitle)]
		ITextFieldWrapper ContentTitle { get; }

		/// <summary>
		/// <para>Template: Title Field</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(TitleFieldItem.IndexFieldNames.ContentTitle)]
		string ContentTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Title Field</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, TitleFieldItem.Constants.TemplateIdStr, typeof(Guid))]
	[TemplateMapping(TitleFieldItem.Constants.TemplateIdStr, "")]
	public partial class TitleFieldItem : CustomItemWrapper, ITitleFieldItem
	{
		private Item _item = null;

		public TitleFieldItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public TitleFieldItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public TitleFieldItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public TitleFieldItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Title Field</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.ContentTitle)]
		public virtual ITextFieldWrapper ContentTitle
		{
			get { return GetField<TextFieldWrapper>(FieldNames.ContentTitle, IndexFieldNames.ContentTitle); }
		}

		/// <summary><para>Template: Title Field</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.ContentTitle)]
		public string ContentTitleValue
		{
			get { return ContentTitle.Value; }
		}
	
		#region TitleFieldItem Constants 

		public static class Constants
		{
			public const string TemplateIdStr = "{352C79B1-B75C-4918-9B5F-FEE4BFFA5642}";
			public static Guid TemplateId = new Guid(TemplateIdStr);
		}

		public static class FieldNames
		{
			public const string ContentTitle = "Content Title";
		}

		public static class IndexFieldNames
		{
			public const string ContentTitle = "content_title";
		}

		#endregion
	}
}

#endregion

#region Body Field (UserDefined)

namespace Testground.Model.Fortis.Templates.UserDefined
{
	using System;
	using System.Collections.Generic;
	using global::Fortis.Model;
	using global::Fortis.Model.Fields;
	using global::Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Body Field</para>
	/// <para>ID: {4210390C-AD6B-451E-ABDB-7F4F04377778}</para>
	/// <para>/sitecore/templates/User Defined/Data/Body Field</para>
	/// </summary>
	[TemplateMapping(BodyFieldItem.Constants.TemplateIdStr, "InterfaceMap")]
	public partial interface IBodyFieldItem : ICustomItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Body Field</para><para>Field: ContentBody</para><para>Data type: Rich Text</para>
		/// </summary>
		[IndexField(BodyFieldItem.IndexFieldNames.ContentBody)]
		IRichTextFieldWrapper ContentBody { get; }

		/// <summary>
		/// <para>Template: Body Field</para><para>Field: ContentBody</para><para>Data type: Rich Text</para>
		/// </summary>
		[IndexField(BodyFieldItem.IndexFieldNames.ContentBody)]
		string ContentBodyValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Body Field</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, BodyFieldItem.Constants.TemplateIdStr, typeof(Guid))]
	[TemplateMapping(BodyFieldItem.Constants.TemplateIdStr, "")]
	public partial class BodyFieldItem : CustomItemWrapper, IBodyFieldItem
	{
		private Item _item = null;

		public BodyFieldItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public BodyFieldItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public BodyFieldItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public BodyFieldItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Body Field</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField(IndexFieldNames.ContentBody)]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>(FieldNames.ContentBody, IndexFieldNames.ContentBody); }
		}

		/// <summary><para>Template: Body Field</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField(IndexFieldNames.ContentBody)]
		public string ContentBodyValue
		{
			get { return ContentBody.Value; }
		}
	
		#region BodyFieldItem Constants 

		public static class Constants
		{
			public const string TemplateIdStr = "{4210390C-AD6B-451E-ABDB-7F4F04377778}";
			public static Guid TemplateId = new Guid(TemplateIdStr);
		}

		public static class FieldNames
		{
			public const string ContentBody = "Content Body";
		}

		public static class IndexFieldNames
		{
			public const string ContentBody = "content_body";
		}

		#endregion
	}
}

#endregion

#region Image Field (UserDefined)

namespace Testground.Model.Fortis.Templates.UserDefined
{
	using System;
	using System.Collections.Generic;
	using global::Fortis.Model;
	using global::Fortis.Model.Fields;
	using global::Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Image Field</para>
	/// <para>ID: {54A1B008-7584-4260-8571-2645F3C5786D}</para>
	/// <para>/sitecore/templates/User Defined/Data/Image Field</para>
	/// </summary>
	[TemplateMapping(ImageFieldItem.Constants.TemplateIdStr, "InterfaceMap")]
	public partial interface IImageFieldItem : ICustomItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Image Field</para><para>Field: ContentImage</para><para>Data type: Image</para>
		/// </summary>
		IImageFieldWrapper ContentImage { get; }
		string ContentImageValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Image Field</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, ImageFieldItem.Constants.TemplateIdStr, typeof(Guid))]
	[TemplateMapping(ImageFieldItem.Constants.TemplateIdStr, "")]
	public partial class ImageFieldItem : CustomItemWrapper, IImageFieldItem
	{
		private Item _item = null;

		public ImageFieldItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ImageFieldItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ImageFieldItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ImageFieldItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Image Field</para><para>Field: ContentImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper ContentImage
		{
			get { return GetField<ImageFieldWrapper>(FieldNames.ContentImage); }
		}

		/// <summary><para>Template: Image Field</para><para>Field: ContentImage</para><para>Data type: Image</para></summary>
		public string ContentImageValue
		{
			get { return ContentImage.Value; }
		}
	
		#region ImageFieldItem Constants 

		public static class Constants
		{
			public const string TemplateIdStr = "{54A1B008-7584-4260-8571-2645F3C5786D}";
			public static Guid TemplateId = new Guid(TemplateIdStr);
		}

		public static class FieldNames
		{
			public const string ContentImage = "Content Image";
		}

		public static class IndexFieldNames
		{
			public const string ContentImage = "content_image";
		}

		#endregion
	}
}

#endregion

#region Content Page (UserDefined)

namespace Testground.Model.Fortis.Templates.UserDefined
{
	using System;
	using System.Collections.Generic;
	using global::Fortis.Model;
	using global::Fortis.Model.Fields;
	using global::Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Content Page</para>
	/// <para>ID: {8DAC2938-20EC-4CB0-BA4E-0DE432AA369E}</para>
	/// <para>/sitecore/templates/User Defined/Page Types/Content Page</para>
	/// </summary>
	[TemplateMapping(ContentPageItem.Constants.TemplateIdStr, "InterfaceMap")]
	public partial interface IContentPageItem : ICustomItemWrapper , Testground.Model.Fortis.Templates.UserDefined.INavigationItem, Testground.Model.Fortis.Templates.UserDefined.ITitleFieldItem, Testground.Model.Fortis.Templates.UserDefined.IBodyFieldItem, Testground.Model.Fortis.Templates.UserDefined.IImageFieldItem, Testground.Model.Fortis.Templates.UserDefined.ISeoItem
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Page Types/Content Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, ContentPageItem.Constants.TemplateIdStr, typeof(Guid))]
	[TemplateMapping(ContentPageItem.Constants.TemplateIdStr, "")]
	public partial class ContentPageItem : CustomItemWrapper, IContentPageItem
	{
		private Item _item = null;

		public ContentPageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentPageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentPageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentPageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField(IndexFieldNames.HideFromNavigation)]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>(FieldNames.HideFromNavigation, IndexFieldNames.HideFromNavigation); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField(IndexFieldNames.HideFromNavigation)]
		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.NavigationTitle)]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>(FieldNames.NavigationTitle, IndexFieldNames.NavigationTitle); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.NavigationTitle)]
		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.ContentTitle)]
		public virtual ITextFieldWrapper ContentTitle
		{
			get { return GetField<TextFieldWrapper>(FieldNames.ContentTitle, IndexFieldNames.ContentTitle); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.ContentTitle)]
		public string ContentTitleValue
		{
			get { return ContentTitle.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField(IndexFieldNames.ContentBody)]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>(FieldNames.ContentBody, IndexFieldNames.ContentBody); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField(IndexFieldNames.ContentBody)]
		public string ContentBodyValue
		{
			get { return ContentBody.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: ContentImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper ContentImage
		{
			get { return GetField<ImageFieldWrapper>(FieldNames.ContentImage); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: ContentImage</para><para>Data type: Image</para></summary>
		public string ContentImageValue
		{
			get { return ContentImage.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaDescription)]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>(FieldNames.MetaDescription, IndexFieldNames.MetaDescription); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaDescription)]
		public string MetaDescriptionValue
		{
			get { return MetaDescription.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaKeywords)]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>(FieldNames.MetaKeywords, IndexFieldNames.MetaKeywords); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaKeywords)]
		public string MetaKeywordsValue
		{
			get { return MetaKeywords.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaTitle)]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>(FieldNames.MetaTitle, IndexFieldNames.MetaTitle); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaTitle)]
		public string MetaTitleValue
		{
			get { return MetaTitle.Value; }
		}
	
		#region ContentPageItem Constants 

		public static class Constants
		{
			public const string TemplateIdStr = "{8DAC2938-20EC-4CB0-BA4E-0DE432AA369E}";
			public static Guid TemplateId = new Guid(TemplateIdStr);
		}

		public static class FieldNames
		{
			public const string HideFromNavigation = "Hide From Navigation";
			public const string NavigationTitle = "Navigation Title";
			public const string ContentTitle = "Content Title";
			public const string ContentBody = "Content Body";
			public const string ContentImage = "Content Image";
			public const string MetaDescription = "Meta Description";
			public const string MetaKeywords = "Meta Keywords";
			public const string MetaTitle = "Meta Title";
		}

		public static class IndexFieldNames
		{
			public const string HideFromNavigation = "hide_from_navigation";
			public const string NavigationTitle = "navigation_title";
			public const string ContentTitle = "content_title";
			public const string ContentBody = "content_body";
			public const string ContentImage = "content_image";
			public const string MetaDescription = "meta_description";
			public const string MetaKeywords = "meta_keywords";
			public const string MetaTitle = "meta_title";
		}

		#endregion
	}
}

#endregion

#region Seo (UserDefined)

namespace Testground.Model.Fortis.Templates.UserDefined
{
	using System;
	using System.Collections.Generic;
	using global::Fortis.Model;
	using global::Fortis.Model.Fields;
	using global::Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Seo</para>
	/// <para>ID: {A7CB2CD5-C4B1-46A6-B92F-4EF8185B45EC}</para>
	/// <para>/sitecore/templates/User Defined/Data/Seo</para>
	/// </summary>
	[TemplateMapping(SeoItem.Constants.TemplateIdStr, "InterfaceMap")]
	public partial interface ISeoItem : ICustomItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(SeoItem.IndexFieldNames.MetaDescription)]
		ITextFieldWrapper MetaDescription { get; }

		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(SeoItem.IndexFieldNames.MetaDescription)]
		string MetaDescriptionValue { get; }
		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(SeoItem.IndexFieldNames.MetaKeywords)]
		ITextFieldWrapper MetaKeywords { get; }

		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(SeoItem.IndexFieldNames.MetaKeywords)]
		string MetaKeywordsValue { get; }
		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(SeoItem.IndexFieldNames.MetaTitle)]
		ITextFieldWrapper MetaTitle { get; }

		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(SeoItem.IndexFieldNames.MetaTitle)]
		string MetaTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Seo</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, SeoItem.Constants.TemplateIdStr, typeof(Guid))]
	[TemplateMapping(SeoItem.Constants.TemplateIdStr, "")]
	public partial class SeoItem : CustomItemWrapper, ISeoItem
	{
		private Item _item = null;

		public SeoItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public SeoItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public SeoItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public SeoItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Seo</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaDescription)]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>(FieldNames.MetaDescription, IndexFieldNames.MetaDescription); }
		}

		/// <summary><para>Template: Seo</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaDescription)]
		public string MetaDescriptionValue
		{
			get { return MetaDescription.Value; }
		}
		/// <summary><para>Template: Seo</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaKeywords)]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>(FieldNames.MetaKeywords, IndexFieldNames.MetaKeywords); }
		}

		/// <summary><para>Template: Seo</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaKeywords)]
		public string MetaKeywordsValue
		{
			get { return MetaKeywords.Value; }
		}
		/// <summary><para>Template: Seo</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaTitle)]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>(FieldNames.MetaTitle, IndexFieldNames.MetaTitle); }
		}

		/// <summary><para>Template: Seo</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.MetaTitle)]
		public string MetaTitleValue
		{
			get { return MetaTitle.Value; }
		}
	
		#region SeoItem Constants 

		public static class Constants
		{
			public const string TemplateIdStr = "{A7CB2CD5-C4B1-46A6-B92F-4EF8185B45EC}";
			public static Guid TemplateId = new Guid(TemplateIdStr);
		}

		public static class FieldNames
		{
			public const string MetaDescription = "Meta Description";
			public const string MetaKeywords = "Meta Keywords";
			public const string MetaTitle = "Meta Title";
		}

		public static class IndexFieldNames
		{
			public const string MetaDescription = "meta_description";
			public const string MetaKeywords = "meta_keywords";
			public const string MetaTitle = "meta_title";
		}

		#endregion
	}
}

#endregion

#region Navigation (UserDefined)

namespace Testground.Model.Fortis.Templates.UserDefined
{
	using System;
	using System.Collections.Generic;
	using global::Fortis.Model;
	using global::Fortis.Model.Fields;
	using global::Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Navigation</para>
	/// <para>ID: {F80BAA4D-5F8B-40EA-BE43-20D649B2C92D}</para>
	/// <para>/sitecore/templates/User Defined/Data/Navigation</para>
	/// </summary>
	[TemplateMapping(NavigationItem.Constants.TemplateIdStr, "InterfaceMap")]
	public partial interface INavigationItem : ICustomItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para>
		/// </summary>
		[IndexField(NavigationItem.IndexFieldNames.HideFromNavigation)]
		IBooleanFieldWrapper HideFromNavigation { get; }

		/// <summary>
		/// <para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para>
		/// </summary>
		[IndexField(NavigationItem.IndexFieldNames.HideFromNavigation)]
		bool HideFromNavigationValue { get; }
		/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
		ITextFieldWrapper NavigationTitle { get; }

		/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
		string NavigationTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Navigation</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, NavigationItem.Constants.TemplateIdStr, typeof(Guid))]
	[TemplateMapping(NavigationItem.Constants.TemplateIdStr, "")]
	public partial class NavigationItem : CustomItemWrapper, INavigationItem
	{
		private Item _item = null;

		public NavigationItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public NavigationItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public NavigationItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public NavigationItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField(IndexFieldNames.HideFromNavigation)]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>(FieldNames.HideFromNavigation, IndexFieldNames.HideFromNavigation); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField(IndexFieldNames.HideFromNavigation)]
		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.NavigationTitle)]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>(FieldNames.NavigationTitle, IndexFieldNames.NavigationTitle); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField(IndexFieldNames.NavigationTitle)]
		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
	
		#region NavigationItem Constants 

		public static class Constants
		{
			public const string TemplateIdStr = "{F80BAA4D-5F8B-40EA-BE43-20D649B2C92D}";
			public static Guid TemplateId = new Guid(TemplateIdStr);
		}

		public static class FieldNames
		{
			public const string HideFromNavigation = "Hide From Navigation";
			public const string NavigationTitle = "Navigation Title";
		}

		public static class IndexFieldNames
		{
			public const string HideFromNavigation = "hide_from_navigation";
			public const string NavigationTitle = "navigation_title";
		}

		#endregion
	}
}

#endregion

