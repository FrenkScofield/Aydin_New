using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
public enum UserType : int
{
    [Description("Admin")]
    Admin = 1,
    [Description("User")]
    FUser = 2
}
public enum SpecType : int
{
    [Description("tanım")]
    tanim = 1,
    [Description("check")]
    check = 2,
    [Description("list")]
    list = 3,
    [Description("text")]
    text = 4,
    [Description("editor")]
    editor = 5
}
public enum TemplateType : int
{
    [Description("Anasayfa")]
    Index = 1, 
    [Description("Alt Sayfa - Dikey")]
    PageVer = 3,
    [Description("Alt Sayfa - Yatay")]
    PageHor = 6,
    [Description("Blog Listeleme")]
    BlogList = 4,
    [Description("Blog Detay")]
    BlogDetail = 5, 
    [Description("İletişim")]
    Contact = 9, 
    [Description("HTML Raw")]
    HtmlRaw = 11
}
public enum EventType : int
{
    [Description("Counter")]
    Counter = 1,
    [Description("tip2")]
    tip2 = 2,

}

public enum ProductsType
{
    [Description("Ürün")]
    Urun = 1,
    [Description("Slider")]
    Slider = 2
}
public enum AttributesType
{
    [Description("Filtre")]
    Filtre = 1,
    [Description("Kategori")]
    Kategori = 2
}


