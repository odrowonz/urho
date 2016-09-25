// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Text.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Gui
{
	/// <summary>
	/// %Text %UI element.
	/// </summary>
	public unsafe partial class Text : UIElement
	{
		public Text (IntPtr handle) : base (handle)
		{
		}

		protected Text (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Text_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Text_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Text_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Text_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Text_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Text));
			return new StringHash (Text_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Text_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Text));
			return Marshal.PtrToStringAnsi (Text_GetTypeNameStatic ());
		}

		public Text () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Text_Text (IntPtr context);

		public Text (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Text));
			handle = Text_Text ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Text));
			Text_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_ApplyAttributes (IntPtr handle);

		/// <summary>
		/// Apply attribute changes that can not be applied immediately.
		/// </summary>
		public override void ApplyAttributes ()
		{
			Runtime.ValidateRefCounted (this);
			Text_ApplyAttributes (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_OnResize (IntPtr handle);

		/// <summary>
		/// React to resize.
		/// </summary>
		public override void OnResize ()
		{
			Runtime.ValidateRefCounted (this);
			Text_OnResize (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_OnIndentSet (IntPtr handle);

		/// <summary>
		/// React to indent change.
		/// </summary>
		public override void OnIndentSet ()
		{
			Runtime.ValidateRefCounted (this);
			Text_OnIndentSet (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Text_SetFont (IntPtr handle, string fontName, int size);

		/// <summary>
		/// Set font by looking from resource cache by name and font size. Return true if successful.
		/// </summary>
		public bool SetFont (string fontName, int size)
		{
			Runtime.ValidateRefCounted (this);
			return Text_SetFont (handle, fontName, size);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Text_SetFont0 (IntPtr handle, IntPtr font, int size);

		/// <summary>
		/// Set font and font size. Return true if successful.
		/// </summary>
		public bool SetFont (Font font, int size)
		{
			Runtime.ValidateRefCounted (this);
			return Text_SetFont0 (handle, (object)font == null ? IntPtr.Zero : font.Handle, size);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Text_SetFontSize (IntPtr handle, int size);

		/// <summary>
		/// Set font size only while retaining the existing font. Return true if successful.
		/// </summary>
		public bool SetFontSize (int size)
		{
			Runtime.ValidateRefCounted (this);
			return Text_SetFontSize (handle, size);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetText (IntPtr handle, string text);

		/// <summary>
		/// Set text. Text is assumed to be either ASCII or UTF8-encoded.
		/// </summary>
		private void SetText (string text)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetText (handle, text);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetTextAlignment (IntPtr handle, HorizontalAlignment align);

		/// <summary>
		/// Set row alignment.
		/// </summary>
		private void SetTextAlignment (HorizontalAlignment align)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetTextAlignment (handle, align);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetRowSpacing (IntPtr handle, float spacing);

		/// <summary>
		/// Set row spacing, 1.0 for original font spacing.
		/// </summary>
		private void SetRowSpacing (float spacing)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetRowSpacing (handle, spacing);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetWordwrap (IntPtr handle, bool enable);

		/// <summary>
		/// Set wordwrap. In wordwrap mode the text element will respect its current width. Otherwise it resizes itself freely.
		/// </summary>
		private void SetWordwrap (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetWordwrap (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetAutoLocalizable (IntPtr handle, bool enable);

		/// <summary>
		/// The text will be automatically translated. The text value used as string identifier.
		/// </summary>
		private void SetAutoLocalizable (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetAutoLocalizable (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetSelection (IntPtr handle, uint start, uint length);

		/// <summary>
		/// Set selection. When length is not provided, select until the text ends.
		/// </summary>
		public void SetSelection (uint start, uint length)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetSelection (handle, start, length);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_ClearSelection (IntPtr handle);

		/// <summary>
		/// Clear selection.
		/// </summary>
		public void ClearSelection ()
		{
			Runtime.ValidateRefCounted (this);
			Text_ClearSelection (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetSelectionColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set selection background color. Color with 0 alpha (default) disables.
		/// </summary>
		private void SetSelectionColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetSelectionColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetHoverColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set hover background color. Color with 0 alpha (default) disables.
		/// </summary>
		private void SetHoverColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetHoverColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetTextEffect (IntPtr handle, TextEffect textEffect);

		/// <summary>
		/// Set text effect.
		/// </summary>
		private void SetTextEffect (TextEffect textEffect)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetTextEffect (handle, textEffect);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetEffectShadowOffset (IntPtr handle, ref Urho.IntVector2 offset);

		/// <summary>
		/// Set shadow offset.
		/// </summary>
		private void SetEffectShadowOffset (Urho.IntVector2 offset)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetEffectShadowOffset (handle, ref offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetEffectStrokeThickness (IntPtr handle, int thickness);

		/// <summary>
		/// Set stroke thickness.
		/// </summary>
		private void SetEffectStrokeThickness (int thickness)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetEffectStrokeThickness (handle, thickness);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetEffectRoundStroke (IntPtr handle, bool roundStroke);

		/// <summary>
		/// Set stroke rounding. Corners of the font will be rounded off in the stroke so the stroke won't have corners.
		/// </summary>
		private void SetEffectRoundStroke (bool roundStroke)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetEffectRoundStroke (handle, roundStroke);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetEffectColor (IntPtr handle, ref Urho.Color effectColor);

		/// <summary>
		/// Set effect color.
		/// </summary>
		private void SetEffectColor (Urho.Color effectColor)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetEffectColor (handle, ref effectColor);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Text_GetFont (IntPtr handle);

		/// <summary>
		/// Return font.
		/// </summary>
		private Font GetFont ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Font> (Text_GetFont (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Text_GetFontSize (IntPtr handle);

		/// <summary>
		/// Return font size.
		/// </summary>
		private int GetFontSize ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetFontSize (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Text_GetText (IntPtr handle);

		/// <summary>
		/// Return text.
		/// </summary>
		private string GetText ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Text_GetText (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern HorizontalAlignment Text_GetTextAlignment (IntPtr handle);

		/// <summary>
		/// Return row alignment.
		/// </summary>
		private HorizontalAlignment GetTextAlignment ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetTextAlignment (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Text_GetRowSpacing (IntPtr handle);

		/// <summary>
		/// Return row spacing.
		/// </summary>
		private float GetRowSpacing ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetRowSpacing (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Text_GetWordwrap (IntPtr handle);

		/// <summary>
		/// Return wordwrap mode.
		/// </summary>
		private bool GetWordwrap ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetWordwrap (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Text_GetAutoLocalizable (IntPtr handle);

		/// <summary>
		/// Return auto localizable mode.
		/// </summary>
		private bool GetAutoLocalizable ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetAutoLocalizable (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Text_GetSelectionStart (IntPtr handle);

		/// <summary>
		/// Return selection start.
		/// </summary>
		private uint GetSelectionStart ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetSelectionStart (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Text_GetSelectionLength (IntPtr handle);

		/// <summary>
		/// Return selection length.
		/// </summary>
		private uint GetSelectionLength ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetSelectionLength (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Text_GetSelectionColor (IntPtr handle);

		/// <summary>
		/// Return selection background color.
		/// </summary>
		private Urho.Color GetSelectionColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetSelectionColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Text_GetHoverColor (IntPtr handle);

		/// <summary>
		/// Return hover background color.
		/// </summary>
		private Urho.Color GetHoverColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetHoverColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern TextEffect Text_GetTextEffect (IntPtr handle);

		/// <summary>
		/// Return text effect.
		/// </summary>
		private TextEffect GetTextEffect ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetTextEffect (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 Text_GetEffectShadowOffset (IntPtr handle);

		/// <summary>
		/// Return effect shadow offset.
		/// </summary>
		private Urho.IntVector2 GetEffectShadowOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetEffectShadowOffset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Text_GetEffectStrokeThickness (IntPtr handle);

		/// <summary>
		/// Return effect stroke thickness.
		/// </summary>
		private int GetEffectStrokeThickness ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetEffectStrokeThickness (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Text_GetEffectRoundStroke (IntPtr handle);

		/// <summary>
		/// Return effect round stroke.
		/// </summary>
		private bool GetEffectRoundStroke ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetEffectRoundStroke (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Text_GetEffectColor (IntPtr handle);

		/// <summary>
		/// Return effect color.
		/// </summary>
		private Urho.Color GetEffectColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetEffectColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Text_GetRowHeight (IntPtr handle);

		/// <summary>
		/// Return row height.
		/// </summary>
		private int GetRowHeight ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetRowHeight (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Text_GetNumRows (IntPtr handle);

		/// <summary>
		/// Return number of rows.
		/// </summary>
		private uint GetNumRows ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetNumRows (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Text_GetNumChars (IntPtr handle);

		/// <summary>
		/// Return number of characters.
		/// </summary>
		private uint GetNumChars ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetNumChars (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Text_GetRowWidth (IntPtr handle, uint index);

		/// <summary>
		/// Return width of row by index.
		/// </summary>
		public int GetRowWidth (uint index)
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetRowWidth (handle, index);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntVector2 Text_GetCharPosition (IntPtr handle, uint index);

		/// <summary>
		/// Return position of character by index relative to the text element origin.
		/// </summary>
		public IntVector2 GetCharPosition (uint index)
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetCharPosition (handle, index);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntVector2 Text_GetCharSize (IntPtr handle, uint index);

		/// <summary>
		/// Return size of character by index.
		/// </summary>
		public IntVector2 GetCharSize (uint index)
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetCharSize (handle, index);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetEffectDepthBias (IntPtr handle, float bias);

		/// <summary>
		/// Set text effect Z bias. Zero by default, adjusted only in 3D mode.
		/// </summary>
		private void SetEffectDepthBias (float bias)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetEffectDepthBias (handle, bias);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Text_GetEffectDepthBias (IntPtr handle);

		/// <summary>
		/// Return effect Z bias.
		/// </summary>
		private float GetEffectDepthBias ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetEffectDepthBias (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ResourceRef Text_GetFontAttr (IntPtr handle);

		/// <summary>
		/// Return font attribute.
		/// </summary>
		private ResourceRef GetFontAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return Text_GetFontAttr (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Text_SetTextAttr (IntPtr handle, string value);

		/// <summary>
		/// Set text attribute.
		/// </summary>
		public void SetTextAttr (string value)
		{
			Runtime.ValidateRefCounted (this);
			Text_SetTextAttr (handle, value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Text_GetTextAttr (IntPtr handle);

		/// <summary>
		/// Return text attribute.
		/// </summary>
		private string GetTextAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Text_GetTextAttr (handle));
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return text.
		/// Or
		/// Set text. Text is assumed to be either ASCII or UTF8-encoded.
		/// </summary>
		public string Value {
			get {
				return GetText ();
			}
			set {
				SetText (value);
			}
		}

		/// <summary>
		/// Return row alignment.
		/// Or
		/// Set row alignment.
		/// </summary>
		public HorizontalAlignment TextAlignment {
			get {
				return GetTextAlignment ();
			}
			set {
				SetTextAlignment (value);
			}
		}

		/// <summary>
		/// Return row spacing.
		/// Or
		/// Set row spacing, 1.0 for original font spacing.
		/// </summary>
		public float RowSpacing {
			get {
				return GetRowSpacing ();
			}
			set {
				SetRowSpacing (value);
			}
		}

		/// <summary>
		/// Return wordwrap mode.
		/// Or
		/// Set wordwrap. In wordwrap mode the text element will respect its current width. Otherwise it resizes itself freely.
		/// </summary>
		public bool Wordwrap {
			get {
				return GetWordwrap ();
			}
			set {
				SetWordwrap (value);
			}
		}

		/// <summary>
		/// Return auto localizable mode.
		/// Or
		/// The text will be automatically translated. The text value used as string identifier.
		/// </summary>
		public bool AutoLocalizable {
			get {
				return GetAutoLocalizable ();
			}
			set {
				SetAutoLocalizable (value);
			}
		}

		/// <summary>
		/// Return selection background color.
		/// Or
		/// Set selection background color. Color with 0 alpha (default) disables.
		/// </summary>
		public Urho.Color SelectionColor {
			get {
				return GetSelectionColor ();
			}
			set {
				SetSelectionColor (value);
			}
		}

		/// <summary>
		/// Return hover background color.
		/// Or
		/// Set hover background color. Color with 0 alpha (default) disables.
		/// </summary>
		public Urho.Color HoverColor {
			get {
				return GetHoverColor ();
			}
			set {
				SetHoverColor (value);
			}
		}

		/// <summary>
		/// Return text effect.
		/// Or
		/// Set text effect.
		/// </summary>
		public TextEffect TextEffect {
			get {
				return GetTextEffect ();
			}
			set {
				SetTextEffect (value);
			}
		}

		/// <summary>
		/// Return effect shadow offset.
		/// Or
		/// Set shadow offset.
		/// </summary>
		public Urho.IntVector2 EffectShadowOffset {
			get {
				return GetEffectShadowOffset ();
			}
			set {
				SetEffectShadowOffset (value);
			}
		}

		/// <summary>
		/// Return effect stroke thickness.
		/// Or
		/// Set stroke thickness.
		/// </summary>
		public int EffectStrokeThickness {
			get {
				return GetEffectStrokeThickness ();
			}
			set {
				SetEffectStrokeThickness (value);
			}
		}

		/// <summary>
		/// Return effect round stroke.
		/// Or
		/// Set stroke rounding. Corners of the font will be rounded off in the stroke so the stroke won't have corners.
		/// </summary>
		public bool EffectRoundStroke {
			get {
				return GetEffectRoundStroke ();
			}
			set {
				SetEffectRoundStroke (value);
			}
		}

		/// <summary>
		/// Return effect color.
		/// Or
		/// Set effect color.
		/// </summary>
		public Urho.Color EffectColor {
			get {
				return GetEffectColor ();
			}
			set {
				SetEffectColor (value);
			}
		}

		/// <summary>
		/// Return font.
		/// </summary>
		public Font Font {
			get {
				return GetFont ();
			}
		}

		/// <summary>
		/// Return font size.
		/// </summary>
		public int FontSize {
			get {
				return GetFontSize ();
			}
		}

		/// <summary>
		/// Return selection start.
		/// </summary>
		public uint SelectionStart {
			get {
				return GetSelectionStart ();
			}
		}

		/// <summary>
		/// Return selection length.
		/// </summary>
		public uint SelectionLength {
			get {
				return GetSelectionLength ();
			}
		}

		/// <summary>
		/// Return row height.
		/// </summary>
		public int RowHeight {
			get {
				return GetRowHeight ();
			}
		}

		/// <summary>
		/// Return number of rows.
		/// </summary>
		public uint NumRows {
			get {
				return GetNumRows ();
			}
		}

		/// <summary>
		/// Return number of characters.
		/// </summary>
		public uint NumChars {
			get {
				return GetNumChars ();
			}
		}

		/// <summary>
		/// Return effect Z bias.
		/// Or
		/// Set text effect Z bias. Zero by default, adjusted only in 3D mode.
		/// </summary>
		public float EffectDepthBias {
			get {
				return GetEffectDepthBias ();
			}
			set {
				SetEffectDepthBias (value);
			}
		}

		/// <summary>
		/// Return font attribute.
		/// </summary>
		public ResourceRef FontAttr {
			get {
				return GetFontAttr ();
			}
		}

		/// <summary>
		/// Return text attribute.
		/// </summary>
		public string TextAttr {
			get {
				return GetTextAttr ();
			}
		}
	}
}