using Sitecore.Data.Items;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Common;

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
	[TemplateMapping("{352C79B1-B75C-4918-9B5F-FEE4BFFA5642}", "InterfaceMap")]
	public partial interface ITitleField : IItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Title Field</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("content_title")]
		ITextFieldWrapper ContentTitle { get; }

		/// <summary>
		/// <para>Template: Title Field</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("content_title")]
		string ContentTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Title Field</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{352C79B1-B75C-4918-9B5F-FEE4BFFA5642}", typeof(Guid))]
	[TemplateMapping("{352C79B1-B75C-4918-9B5F-FEE4BFFA5642}", "")]
	public partial class TitleField : ItemWrapper, ITitleField
	{
		private Item _item = null;

		public TitleField(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public TitleField(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public TitleField(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public TitleField(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Title Field</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("content_title")]
		public virtual ITextFieldWrapper ContentTitle
		{
			get { return GetField<TextFieldWrapper>("Content Title", "content_title"); }
		}

		/// <summary><para>Template: Title Field</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("content_title")]
		public string ContentTitleValue
		{
			get { return ContentTitle.Value; }
		}
	
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
	[TemplateMapping("{4210390C-AD6B-451E-ABDB-7F4F04377778}", "InterfaceMap")]
	public partial interface IBodyField : IItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Body Field</para><para>Field: ContentBody</para><para>Data type: Rich Text</para>
		/// </summary>
		[IndexField("content_body")]
		IRichTextFieldWrapper ContentBody { get; }

		/// <summary>
		/// <para>Template: Body Field</para><para>Field: ContentBody</para><para>Data type: Rich Text</para>
		/// </summary>
		[IndexField("content_body")]
		string ContentBodyValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Body Field</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{4210390C-AD6B-451E-ABDB-7F4F04377778}", typeof(Guid))]
	[TemplateMapping("{4210390C-AD6B-451E-ABDB-7F4F04377778}", "")]
	public partial class BodyField : ItemWrapper, IBodyField
	{
		private Item _item = null;

		public BodyField(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public BodyField(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public BodyField(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public BodyField(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Body Field</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body"); }
		}

		/// <summary><para>Template: Body Field</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
		public string ContentBodyValue
		{
			get { return ContentBody.Value; }
		}
	
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
	[TemplateMapping("{54A1B008-7584-4260-8571-2645F3C5786D}", "InterfaceMap")]
	public partial interface IImageField : IItemWrapper 
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
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{54A1B008-7584-4260-8571-2645F3C5786D}", typeof(Guid))]
	[TemplateMapping("{54A1B008-7584-4260-8571-2645F3C5786D}", "")]
	public partial class ImageField : ItemWrapper, IImageField
	{
		private Item _item = null;

		public ImageField(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ImageField(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ImageField(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ImageField(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Image Field</para><para>Field: ContentImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper ContentImage
		{
			get { return GetField<ImageFieldWrapper>("Content Image"); }
		}

		/// <summary><para>Template: Image Field</para><para>Field: ContentImage</para><para>Data type: Image</para></summary>
		public string ContentImageValue
		{
			get { return ContentImage.Value; }
		}
	
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
	[TemplateMapping("{8DAC2938-20EC-4CB0-BA4E-0DE432AA369E}", "InterfaceMap")]
	public partial interface IContentPage : IItemWrapper , Testground.Model.Fortis.Templates.UserDefined.INavigation, Testground.Model.Fortis.Templates.UserDefined.ITitleField, Testground.Model.Fortis.Templates.UserDefined.IBodyField, Testground.Model.Fortis.Templates.UserDefined.IImageField, Testground.Model.Fortis.Templates.UserDefined.ISeo
	{		
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Page Types/Content Page</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{8DAC2938-20EC-4CB0-BA4E-0DE432AA369E}", typeof(Guid))]
	[TemplateMapping("{8DAC2938-20EC-4CB0-BA4E-0DE432AA369E}", "")]
	public partial class ContentPage : ItemWrapper, IContentPage
	{
		private Item _item = null;

		public ContentPage(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContentPage(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContentPage(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContentPage(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("content_title")]
		public virtual ITextFieldWrapper ContentTitle
		{
			get { return GetField<TextFieldWrapper>("Content Title", "content_title"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: ContentTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("content_title")]
		public string ContentTitleValue
		{
			get { return ContentTitle.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
		public virtual IRichTextFieldWrapper ContentBody
		{
			get { return GetField<RichTextFieldWrapper>("Content Body", "content_body"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: ContentBody</para><para>Data type: Rich Text</para></summary>
		[IndexField("content_body")]
		public string ContentBodyValue
		{
			get { return ContentBody.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: ContentImage</para><para>Data type: Image</para></summary>
		public virtual IImageFieldWrapper ContentImage
		{
			get { return GetField<ImageFieldWrapper>("Content Image"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: ContentImage</para><para>Data type: Image</para></summary>
		public string ContentImageValue
		{
			get { return ContentImage.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_description")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_description")]
		public string MetaDescriptionValue
		{
			get { return MetaDescription.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
		public string MetaKeywordsValue
		{
			get { return MetaKeywords.Value; }
		}
		/// <summary><para>Template: Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title"); }
		}

		/// <summary><para>Template: Content Page</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
		public string MetaTitleValue
		{
			get { return MetaTitle.Value; }
		}
	
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
	[TemplateMapping("{A7CB2CD5-C4B1-46A6-B92F-4EF8185B45EC}", "InterfaceMap")]
	public partial interface ISeo : IItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("meta_description")]
		ITextFieldWrapper MetaDescription { get; }

		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("meta_description")]
		string MetaDescriptionValue { get; }
		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("meta_keywords")]
		ITextFieldWrapper MetaKeywords { get; }

		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("meta_keywords")]
		string MetaKeywordsValue { get; }
		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("meta_title")]
		ITextFieldWrapper MetaTitle { get; }

		/// <summary>
		/// <para>Template: Seo</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("meta_title")]
		string MetaTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Seo</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{A7CB2CD5-C4B1-46A6-B92F-4EF8185B45EC}", typeof(Guid))]
	[TemplateMapping("{A7CB2CD5-C4B1-46A6-B92F-4EF8185B45EC}", "")]
	public partial class Seo : ItemWrapper, ISeo
	{
		private Item _item = null;

		public Seo(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Seo(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Seo(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Seo(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Seo</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_description")]
		public virtual ITextFieldWrapper MetaDescription
		{
			get { return GetField<TextFieldWrapper>("Meta Description", "meta_description"); }
		}

		/// <summary><para>Template: Seo</para><para>Field: MetaDescription</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_description")]
		public string MetaDescriptionValue
		{
			get { return MetaDescription.Value; }
		}
		/// <summary><para>Template: Seo</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
		public virtual ITextFieldWrapper MetaKeywords
		{
			get { return GetField<TextFieldWrapper>("Meta Keywords", "meta_keywords"); }
		}

		/// <summary><para>Template: Seo</para><para>Field: MetaKeywords</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_keywords")]
		public string MetaKeywordsValue
		{
			get { return MetaKeywords.Value; }
		}
		/// <summary><para>Template: Seo</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
		public virtual ITextFieldWrapper MetaTitle
		{
			get { return GetField<TextFieldWrapper>("Meta Title", "meta_title"); }
		}

		/// <summary><para>Template: Seo</para><para>Field: MetaTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("meta_title")]
		public string MetaTitleValue
		{
			get { return MetaTitle.Value; }
		}
	
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
	[TemplateMapping("{F80BAA4D-5F8B-40EA-BE43-20D649B2C92D}", "InterfaceMap")]
	public partial interface INavigation : IItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para>
		/// </summary>
		[IndexField("hide_from_navigation")]
		IBooleanFieldWrapper HideFromNavigation { get; }

		/// <summary>
		/// <para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para>
		/// </summary>
		[IndexField("hide_from_navigation")]
		bool HideFromNavigationValue { get; }
		/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("navigation_title")]
		ITextFieldWrapper NavigationTitle { get; }

		/// <summary>
		/// <para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("navigation_title")]
		string NavigationTitleValue { get; }
	}

	/// <summary>
	/// <para>Template class</para><para>/sitecore/templates/User Defined/Data/Navigation</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{F80BAA4D-5F8B-40EA-BE43-20D649B2C92D}", typeof(Guid))]
	[TemplateMapping("{F80BAA4D-5F8B-40EA-BE43-20D649B2C92D}", "")]
	public partial class Navigation : ItemWrapper, INavigation
	{
		private Item _item = null;

		public Navigation(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public Navigation(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public Navigation(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public Navigation(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary><para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
		public virtual IBooleanFieldWrapper HideFromNavigation
		{
			get { return GetField<BooleanFieldWrapper>("Hide From Navigation", "hide_from_navigation"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: HideFromNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("hide_from_navigation")]
		public bool HideFromNavigationValue
		{
			get { return HideFromNavigation.Value; }
		}
		/// <summary><para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
		public virtual ITextFieldWrapper NavigationTitle
		{
			get { return GetField<TextFieldWrapper>("Navigation Title", "navigation_title"); }
		}

		/// <summary><para>Template: Navigation</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigation_title")]
		public string NavigationTitleValue
		{
			get { return NavigationTitle.Value; }
		}
	
	}
}
#endregion

