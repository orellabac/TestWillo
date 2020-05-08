#pragma warning disable
#line 1 "frmAddStockManual.cs"
#pragma warning disable
#line 1 "frmAddStockManual.cs"
using Microsoft.VisualBasic;
using System;
using System.Media;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmAddStockManual
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[38];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_editingData)>0)
{yield return "editingData";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentIdProduct)>0)
{yield return "currentIdProduct";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentQuantityPerUnit)>0)
{yield return "currentQuantityPerUnit";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentUnit)>0)
{yield return "currentUnit";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentProductName)>0)
{yield return "currentProductName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentPriceReference)>0)
{yield return "currentPriceReference";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_codeGeneratedChange)>0)
{yield return "codeGeneratedChange";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_quantity)>0)
{yield return "quantity";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_stockPrice)>0)
{yield return "stockPrice";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_unitPrice)>0)
{yield return "unitPrice";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0)
{yield return "visualControls";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0)
{yield return "components";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0)
{yield return "ToolTipMain";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSave)>0)
{yield return "cmdSave";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0)
{yield return "cmdClose";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0)
{yield return "sbStatusBar_Panels_Panel1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0)
{yield return "sbStatusBar";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtUnit)>0)
{yield return "txtUnit";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProductName)>0)
{yield return "txtProductName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtQuantityPerUnit)>0)
{yield return "txtQuantityPerUnit";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtValues_2)>0)
{yield return "_txtValues_2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtValues_1)>0)
{yield return "_txtValues_1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtValues_0)>0)
{yield return "_txtValues_0";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdProducts)>0)
{yield return "cmdProducts";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtName)>0)
{yield return "txtName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtCode)>0)
{yield return "txtCode";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0)
{yield return "Label4";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label5)>0)
{yield return "Label5";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame1)>0)
{yield return "Frame1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_1_)>0)
{yield return "lvProducts_ColumnHeader_1_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_2_)>0)
{yield return "lvProducts_ColumnHeader_2_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_3_)>0)
{yield return "lvProducts_ColumnHeader_3_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts_ColumnHeader_4_)>0)
{yield return "lvProducts_ColumnHeader_4_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts_ColumnHeader_5_)>0)
{yield return "lvProducts_ColumnHeader_5_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts_ColumnHeader_6_)>0)
{yield return "lvProducts_ColumnHeader_6_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts_ColumnHeader_7_)>0)
{yield return "lvProducts_ColumnHeader_7_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts)>0)
{yield return "lvProducts";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lblNewQuantity)>0)
{yield return "lblNewQuantity";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label10)>0)
{yield return "Label10";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label9)>0)
{yield return "Label9";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label8)>0)
{yield return "Label8";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label7)>0)
{yield return "Label7";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label6)>0)
{yield return "Label6";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label1)>0)
{yield return "Label1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label2)>0)
{yield return "Label2";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label3)>0)
{yield return "Label3";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtValues)>0)
{yield return "txtValues";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_listViewHelper1)>0)
{yield return "listViewHelper1";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "editingData":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_editingData)>0;
case "currentIdProduct":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentIdProduct)>0;
case "currentQuantityPerUnit":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentQuantityPerUnit)>0;
case "currentUnit":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentUnit)>0;
case "currentProductName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentProductName)>0;
case "currentPriceReference":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentPriceReference)>0;
case "codeGeneratedChange":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_codeGeneratedChange)>0;
case "quantity":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_quantity)>0;
case "stockPrice":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_stockPrice)>0;
case "unitPrice":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_unitPrice)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "cmdSave":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSave)>0;
case "cmdClose":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0;
case "sbStatusBar_Panels_Panel1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0;
case "sbStatusBar":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0;
case "txtUnit":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtUnit)>0;
case "txtProductName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProductName)>0;
case "txtQuantityPerUnit":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtQuantityPerUnit)>0;
case "_txtValues_2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtValues_2)>0;
case "_txtValues_1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtValues_1)>0;
case "_txtValues_0":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtValues_0)>0;
case "cmdProducts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdProducts)>0;
case "txtName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtName)>0;
case "txtCode":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtCode)>0;
case "Label4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0;
case "Label5":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label5)>0;
case "Frame1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame1)>0;
case "lvProducts_ColumnHeader_1_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_1_)>0;
case "lvProducts_ColumnHeader_2_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_2_)>0;
case "lvProducts_ColumnHeader_3_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_3_)>0;
case "lvProducts_ColumnHeader_4_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts_ColumnHeader_4_)>0;
case "lvProducts_ColumnHeader_5_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts_ColumnHeader_5_)>0;
case "lvProducts_ColumnHeader_6_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts_ColumnHeader_6_)>0;
case "lvProducts_ColumnHeader_7_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts_ColumnHeader_7_)>0;
case "lvProducts":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProducts)>0;
case "lblNewQuantity":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lblNewQuantity)>0;
case "Label10":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label10)>0;
case "Label9":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label9)>0;
case "Label8":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label8)>0;
case "Label7":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label7)>0;
case "Label6":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label6)>0;
case "Label1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label1)>0;
case "Label2":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label2)>0;
case "Label3":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label3)>0;
case "txtValues":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtValues)>0;
case "listViewHelper1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_listViewHelper1)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["cmdSave"]=_Mobilize_References[3];
refs["cmdClose"]=_Mobilize_References[4];
refs["sbStatusBar_Panels_Panel1"]=_Mobilize_References[5];
refs["sbStatusBar"]=_Mobilize_References[6];
refs["txtUnit"]=_Mobilize_References[7];
refs["txtProductName"]=_Mobilize_References[8];
refs["txtQuantityPerUnit"]=_Mobilize_References[9];
refs["_txtValues_2"]=_Mobilize_References[10];
refs["_txtValues_1"]=_Mobilize_References[11];
refs["_txtValues_0"]=_Mobilize_References[12];
refs["cmdProducts"]=_Mobilize_References[13];
refs["txtName"]=_Mobilize_References[14];
refs["txtCode"]=_Mobilize_References[15];
refs["Label4"]=_Mobilize_References[16];
refs["Label5"]=_Mobilize_References[17];
refs["Frame1"]=_Mobilize_References[18];
refs["lvProducts_ColumnHeader_1_"]=_Mobilize_References[19];
refs["lvProducts_ColumnHeader_2_"]=_Mobilize_References[20];
refs["lvProducts_ColumnHeader_3_"]=_Mobilize_References[21];
refs["lvProducts_ColumnHeader_4_"]=_Mobilize_References[22];
refs["lvProducts_ColumnHeader_5_"]=_Mobilize_References[23];
refs["lvProducts_ColumnHeader_6_"]=_Mobilize_References[24];
refs["lvProducts_ColumnHeader_7_"]=_Mobilize_References[25];
refs["lvProducts"]=_Mobilize_References[26];
refs["lblNewQuantity"]=_Mobilize_References[27];
refs["Label10"]=_Mobilize_References[28];
refs["Label9"]=_Mobilize_References[29];
refs["Label8"]=_Mobilize_References[30];
refs["Label7"]=_Mobilize_References[31];
refs["Label6"]=_Mobilize_References[32];
refs["Label1"]=_Mobilize_References[33];
refs["Label2"]=_Mobilize_References[34];
refs["Label3"]=_Mobilize_References[35];
refs["txtValues"]=_Mobilize_References[36];
refs["listViewHelper1"]=_Mobilize_References[37];
return refs;
}
protected override void _Mobilize_CleanChanges()
{if(!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew||((Mobilize.WebMap.Common.Core.IObservable)this).RefCount>0)
{this._Mobilize_DirtyFlag_0=0;
this._Mobilize_DirtyFlag_1=0;
this._Mobilize_LoadedFlag_0=0;
this._Mobilize_LoadedFlag_1=0;
this._Mobilize_ControlFlag=0;
}
base._Mobilize_CleanChanges();}
protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
{foreach ( var baseRef in base._Mobilize_GetReferences()) {yield return baseRef;
}var ref_visualControls=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.visualControls);if(ref_visualControls!=null)yield return ref_visualControls;
var ref_components=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.components);if(ref_components!=null)yield return ref_components;
var ref_ToolTipMain=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.ToolTipMain);if(ref_ToolTipMain!=null)yield return ref_ToolTipMain;
var ref_cmdSave=(Mobilize.WebMap.Common.Core.IObservable)this.cmdSave;if(ref_cmdSave!=null)yield return ref_cmdSave;
var ref_cmdClose=(Mobilize.WebMap.Common.Core.IObservable)this.cmdClose;if(ref_cmdClose!=null)yield return ref_cmdClose;
var ref_sbStatusBar_Panels_Panel1=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar_Panels_Panel1;if(ref_sbStatusBar_Panels_Panel1!=null)yield return ref_sbStatusBar_Panels_Panel1;
var ref_sbStatusBar=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar;if(ref_sbStatusBar!=null)yield return ref_sbStatusBar;
var ref_txtUnit=(Mobilize.WebMap.Common.Core.IObservable)this.txtUnit;if(ref_txtUnit!=null)yield return ref_txtUnit;
var ref_txtProductName=(Mobilize.WebMap.Common.Core.IObservable)this.txtProductName;if(ref_txtProductName!=null)yield return ref_txtProductName;
var ref_txtQuantityPerUnit=(Mobilize.WebMap.Common.Core.IObservable)this.txtQuantityPerUnit;if(ref_txtQuantityPerUnit!=null)yield return ref_txtQuantityPerUnit;
var ref__txtValues_2=(Mobilize.WebMap.Common.Core.IObservable)this._txtValues_2;if(ref__txtValues_2!=null)yield return ref__txtValues_2;
var ref__txtValues_1=(Mobilize.WebMap.Common.Core.IObservable)this._txtValues_1;if(ref__txtValues_1!=null)yield return ref__txtValues_1;
var ref__txtValues_0=(Mobilize.WebMap.Common.Core.IObservable)this._txtValues_0;if(ref__txtValues_0!=null)yield return ref__txtValues_0;
var ref_cmdProducts=(Mobilize.WebMap.Common.Core.IObservable)this.cmdProducts;if(ref_cmdProducts!=null)yield return ref_cmdProducts;
var ref_txtName=(Mobilize.WebMap.Common.Core.IObservable)this.txtName;if(ref_txtName!=null)yield return ref_txtName;
var ref_txtCode=(Mobilize.WebMap.Common.Core.IObservable)this.txtCode;if(ref_txtCode!=null)yield return ref_txtCode;
var ref_Label4=(Mobilize.WebMap.Common.Core.IObservable)this.Label4;if(ref_Label4!=null)yield return ref_Label4;
var ref_Label5=(Mobilize.WebMap.Common.Core.IObservable)this.Label5;if(ref_Label5!=null)yield return ref_Label5;
var ref_Frame1=(Mobilize.WebMap.Common.Core.IObservable)this.Frame1;if(ref_Frame1!=null)yield return ref_Frame1;
var ref_lvProducts_ColumnHeader_1_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_1_;if(ref_lvProducts_ColumnHeader_1_!=null)yield return ref_lvProducts_ColumnHeader_1_;
var ref_lvProducts_ColumnHeader_2_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_2_;if(ref_lvProducts_ColumnHeader_2_!=null)yield return ref_lvProducts_ColumnHeader_2_;
var ref_lvProducts_ColumnHeader_3_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_3_;if(ref_lvProducts_ColumnHeader_3_!=null)yield return ref_lvProducts_ColumnHeader_3_;
var ref_lvProducts_ColumnHeader_4_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_4_;if(ref_lvProducts_ColumnHeader_4_!=null)yield return ref_lvProducts_ColumnHeader_4_;
var ref_lvProducts_ColumnHeader_5_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_5_;if(ref_lvProducts_ColumnHeader_5_!=null)yield return ref_lvProducts_ColumnHeader_5_;
var ref_lvProducts_ColumnHeader_6_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_6_;if(ref_lvProducts_ColumnHeader_6_!=null)yield return ref_lvProducts_ColumnHeader_6_;
var ref_lvProducts_ColumnHeader_7_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_7_;if(ref_lvProducts_ColumnHeader_7_!=null)yield return ref_lvProducts_ColumnHeader_7_;
var ref_lvProducts=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts;if(ref_lvProducts!=null)yield return ref_lvProducts;
var ref_lblNewQuantity=(Mobilize.WebMap.Common.Core.IObservable)this.lblNewQuantity;if(ref_lblNewQuantity!=null)yield return ref_lblNewQuantity;
var ref_Label10=(Mobilize.WebMap.Common.Core.IObservable)this.Label10;if(ref_Label10!=null)yield return ref_Label10;
var ref_Label9=(Mobilize.WebMap.Common.Core.IObservable)this.Label9;if(ref_Label9!=null)yield return ref_Label9;
var ref_Label8=(Mobilize.WebMap.Common.Core.IObservable)this.Label8;if(ref_Label8!=null)yield return ref_Label8;
var ref_Label7=(Mobilize.WebMap.Common.Core.IObservable)this.Label7;if(ref_Label7!=null)yield return ref_Label7;
var ref_Label6=(Mobilize.WebMap.Common.Core.IObservable)this.Label6;if(ref_Label6!=null)yield return ref_Label6;
var ref_Label1=(Mobilize.WebMap.Common.Core.IObservable)this.Label1;if(ref_Label1!=null)yield return ref_Label1;
var ref_Label2=(Mobilize.WebMap.Common.Core.IObservable)this.Label2;if(ref_Label2!=null)yield return ref_Label2;
var ref_Label3=(Mobilize.WebMap.Common.Core.IObservable)this.Label3;if(ref_Label3!=null)yield return ref_Label3;
var ref_txtValues=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.txtValues);if(ref_txtValues!=null)yield return ref_txtValues;
var ref_listViewHelper1=(Mobilize.WebMap.Common.Core.IObservable)this.listViewHelper1;if(ref_listViewHelper1!=null)yield return ref_listViewHelper1;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_DirtyFlag_1;
private uint _Mobilize_LoadedFlag_0;
private uint _Mobilize_LoadedFlag_1;
const uint _Mobilize_Dirty_editingData=(uint)1<<0;
const uint _Mobilize_Dirty_currentIdProduct=(uint)1<<1;
const uint _Mobilize_Dirty_currentQuantityPerUnit=(uint)1<<2;
const uint _Mobilize_Dirty_currentUnit=(uint)1<<3;
const uint _Mobilize_Dirty_currentProductName=(uint)1<<4;
const uint _Mobilize_Dirty_currentPriceReference=(uint)1<<5;
const uint _Mobilize_Dirty_codeGeneratedChange=(uint)1<<6;
const uint _Mobilize_Dirty_quantity=(uint)1<<7;
const uint _Mobilize_Dirty_stockPrice=(uint)1<<8;
const uint _Mobilize_Dirty_unitPrice=(uint)1<<9;
const uint _Mobilize_Dirty_visualControls=(uint)1<<10;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<11;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<12;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_cmdSave=(uint)1<<13;
const uint _Mobilize_Loaded_cmdSave=(uint)1<<3;
const uint _Mobilize_Dirty_cmdClose=(uint)1<<14;
const uint _Mobilize_Loaded_cmdClose=(uint)1<<4;
const uint _Mobilize_Dirty_sbStatusBar_Panels_Panel1=(uint)1<<15;
const uint _Mobilize_Loaded_sbStatusBar_Panels_Panel1=(uint)1<<5;
const uint _Mobilize_Dirty_sbStatusBar=(uint)1<<16;
const uint _Mobilize_Loaded_sbStatusBar=(uint)1<<6;
const uint _Mobilize_Dirty_txtUnit=(uint)1<<17;
const uint _Mobilize_Loaded_txtUnit=(uint)1<<7;
const uint _Mobilize_Dirty_txtProductName=(uint)1<<18;
const uint _Mobilize_Loaded_txtProductName=(uint)1<<8;
const uint _Mobilize_Dirty_txtQuantityPerUnit=(uint)1<<19;
const uint _Mobilize_Loaded_txtQuantityPerUnit=(uint)1<<9;
const uint _Mobilize_Dirty__txtValues_2=(uint)1<<20;
const uint _Mobilize_Loaded__txtValues_2=(uint)1<<10;
const uint _Mobilize_Dirty__txtValues_1=(uint)1<<21;
const uint _Mobilize_Loaded__txtValues_1=(uint)1<<11;
const uint _Mobilize_Dirty__txtValues_0=(uint)1<<22;
const uint _Mobilize_Loaded__txtValues_0=(uint)1<<12;
const uint _Mobilize_Dirty_cmdProducts=(uint)1<<23;
const uint _Mobilize_Loaded_cmdProducts=(uint)1<<13;
const uint _Mobilize_Dirty_txtName=(uint)1<<24;
const uint _Mobilize_Loaded_txtName=(uint)1<<14;
const uint _Mobilize_Dirty_txtCode=(uint)1<<25;
const uint _Mobilize_Loaded_txtCode=(uint)1<<15;
const uint _Mobilize_Dirty_Label4=(uint)1<<26;
const uint _Mobilize_Loaded_Label4=(uint)1<<16;
const uint _Mobilize_Dirty_Label5=(uint)1<<27;
const uint _Mobilize_Loaded_Label5=(uint)1<<17;
const uint _Mobilize_Dirty_Frame1=(uint)1<<28;
const uint _Mobilize_Loaded_Frame1=(uint)1<<18;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_1_=(uint)1<<29;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_1_=(uint)1<<19;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_2_=(uint)1<<30;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_2_=(uint)1<<20;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_3_=(uint)1<<31;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_3_=(uint)1<<21;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_4_=(uint)1<<32;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_4_=(uint)1<<22;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_5_=(uint)1<<33;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_5_=(uint)1<<23;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_6_=(uint)1<<34;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_6_=(uint)1<<24;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_7_=(uint)1<<35;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_7_=(uint)1<<25;
const uint _Mobilize_Dirty_lvProducts=(uint)1<<36;
const uint _Mobilize_Loaded_lvProducts=(uint)1<<26;
const uint _Mobilize_Dirty_lblNewQuantity=(uint)1<<37;
const uint _Mobilize_Loaded_lblNewQuantity=(uint)1<<27;
const uint _Mobilize_Dirty_Label10=(uint)1<<38;
const uint _Mobilize_Loaded_Label10=(uint)1<<28;
const uint _Mobilize_Dirty_Label9=(uint)1<<39;
const uint _Mobilize_Loaded_Label9=(uint)1<<29;
const uint _Mobilize_Dirty_Label8=(uint)1<<40;
const uint _Mobilize_Loaded_Label8=(uint)1<<30;
const uint _Mobilize_Dirty_Label7=(uint)1<<41;
const uint _Mobilize_Loaded_Label7=(uint)1<<31;
const uint _Mobilize_Dirty_Label6=(uint)1<<42;
const uint _Mobilize_Loaded_Label6=(uint)1<<32;
const uint _Mobilize_Dirty_Label1=(uint)1<<43;
const uint _Mobilize_Loaded_Label1=(uint)1<<33;
const uint _Mobilize_Dirty_Label2=(uint)1<<44;
const uint _Mobilize_Loaded_Label2=(uint)1<<34;
const uint _Mobilize_Dirty_Label3=(uint)1<<45;
const uint _Mobilize_Loaded_Label3=(uint)1<<35;
const uint _Mobilize_Dirty_txtValues=(uint)1<<46;
const uint _Mobilize_Loaded_txtValues=(uint)1<<36;
const uint _Mobilize_Dirty_listViewHelper1=(uint)1<<47;
const uint _Mobilize_Loaded_listViewHelper1=(uint)1<<37;
private void Mobilize_Initialize_Properties()
{
#line 20
                                             this.editingData=false;
#line hidden
 
#line 23
                                                    this.currentIdProduct="";
#line hidden
 
#line 26
                                                          this.currentQuantityPerUnit="";
#line hidden
 
#line 29
                                               this.currentUnit="";
#line hidden
 
#line 32
                                                      this.currentProductName="";
#line hidden
 
#line 35
                                                         this.currentPriceReference=0;
#line hidden
 
#line 38
                                                     this.codeGeneratedChange=false;
#line hidden
 
#line 41
                                            this.quantity=0;
#line hidden
 
#line 44
                                              this.stockPrice=0;
#line hidden
 
#line 47
                                             this.unitPrice=0;
#line hidden
 
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "cmdSave", "cmdClose", "sbStatusBar_Panels_Panel1", "sbStatusBar", "txtUnit", "txtProductName", "txtQuantityPerUnit", "_txtValues_2", "_txtValues_1", "_txtValues_0", "cmdProducts", "txtName", "txtCode", "Label4", "Label5", "Frame1", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "lblNewQuantity", "Label10", "Label9", "Label8", "Label7", "Label6", "Label1", "Label2", "Label3", "txtValues", "listViewHelper1"};
#line hidden
 
#line 158
                                                            this.txtValues=new Mobilize.Web.TextBox[3];
#line hidden
 }
#line 15
    

#line hidden
                                             
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool editingData_k__BackingField;
#line 20
                                             

      [Intercepted]


      private bool editingData 
#line 20
                               { 
#line 20
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.editingData_k__BackingField;} 
#line 20

#line 20
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_editingData;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.editingData_k__BackingField=(bool)value;} 
#line 20
                                           } 
#line 21

#line hidden
                                                    
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string currentIdProduct_k__BackingField;
#line 23
                                                    

      [Intercepted]
      private string currentIdProduct 
#line 23
                                      { 
#line 23
                                        get                                           
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentIdProduct_k__BackingField;} 
#line 23

#line 23
                                             set                                                
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentIdProduct;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentIdProduct_k__BackingField=(string)value;} 
#line 23
                                                  } 
#line 24

#line hidden
                                                          
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string currentQuantityPerUnit_k__BackingField;
#line 26
                                                          

      [Intercepted]
      private string currentQuantityPerUnit 
#line 26
                                            { 
#line 26
                                              get                                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentQuantityPerUnit_k__BackingField;} 
#line 26

#line 26
                                                   set                                                      
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentQuantityPerUnit;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentQuantityPerUnit_k__BackingField=(string)value;} 
#line 26
                                                        } 
#line 27

#line hidden
                                               
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string currentUnit_k__BackingField;
#line 29
                                               

      [Intercepted]
      private string currentUnit 
#line 29
                                 { 
#line 29
                                   get                                      
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentUnit_k__BackingField;} 
#line 29

#line 29
                                        set                                           
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentUnit;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentUnit_k__BackingField=(string)value;} 
#line 29
                                             } 
#line 30

#line hidden
                                                      
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string currentProductName_k__BackingField;
#line 32
                                                      

      [Intercepted]
      private string currentProductName 
#line 32
                                        { 
#line 32
                                          get                                             
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentProductName_k__BackingField;} 
#line 32

#line 32
                                               set                                                  
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentProductName;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentProductName_k__BackingField=(string)value;} 
#line 32
                                                    } 
#line 33

#line hidden
                                                         
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentPriceReference_k__BackingField;
#line 35
                                                         

      [Intercepted]
      private double currentPriceReference 
#line 35
                                           { 
#line 35
                                             get                                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentPriceReference_k__BackingField;} 
#line 35

#line 35
                                                  set                                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentPriceReference;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentPriceReference_k__BackingField=(double)value;} 
#line 35
                                                       } 
#line 36

#line hidden
                                                     
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool codeGeneratedChange_k__BackingField;
#line 38
                                                     

      [Intercepted]
      private bool codeGeneratedChange 
#line 38
                                       { 
#line 38
                                         get                                            
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.codeGeneratedChange_k__BackingField;} 
#line 38

#line 38
                                              set                                                 
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_codeGeneratedChange;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.codeGeneratedChange_k__BackingField=(bool)value;} 
#line 38
                                                   } 
#line 39

#line hidden
                                            
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double quantity_k__BackingField;
#line 41
                                            

      [Intercepted]
      private double quantity 
#line 41
                              { 
#line 41
                                get                                   
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.quantity_k__BackingField;} 
#line 41

#line 41
                                     set                                        
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_quantity;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.quantity_k__BackingField=(double)value;} 
#line 41
                                          } 
#line 42

#line hidden
                                              
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double stockPrice_k__BackingField;
#line 44
                                              

      [Intercepted]
      private double stockPrice 
#line 44
                                { 
#line 44
                                  get                                     
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.stockPrice_k__BackingField;} 
#line 44

#line 44
                                       set                                          
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_stockPrice;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.stockPrice_k__BackingField=(double)value;} 
#line 44
                                            } 
#line 45

#line hidden
                                             
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double unitPrice_k__BackingField;
#line 47
                                             

      [Intercepted]
      private double unitPrice 
#line 47
                               { 
#line 47
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.unitPrice_k__BackingField;} 
#line 47

#line 47
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_unitPrice;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.unitPrice_k__BackingField=(double)value;} 
#line 47
                                           } 
#line 48


      public frmAddStockManual()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 52
      	if (m_vb6FormDefInstance == null)
         {
         	if (m_InitializingDefInstance)
         	{
         		m_vb6FormDefInstance = this;
         	}
         	else
         	{
         		try
         		{
         			//For the start-up form, the first instance created is the default instance.
         			if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                  {
                  	m_vb6FormDefInstance = this;
                  }
               }
               catch
               {
               }
            }
         }
         //This call is required by the Windows Form Designer.
         InitializeComponent();
         ReLoadForm(false);
      }



      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
      	this.Close();
      }

      private void cmdProducts_Click(Object eventSender, EventArgs eventArgs)
      {
      	frmProducts.DefInstance.ShowDialog();
      	txtCode.Text = frmProducts.DefInstance.CurrentProductID;
      	txtName.Text = "";
      	DoSearchProduct();
      }

      private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
      {
      	int newStockId = 0;
      	int newManualLogId = 0;
      	int newStockLogId = 0;
      	editingData = false;
      	try
      	{
      		modConnection.ExecuteSql("Select * from Stocks");
      		modConnection.rs.AddNew();
      		modConnection.rs["ProductID"] = currentIdProduct;
      		modConnection.rs["Stock"] = txtValues[0].Text;
      		modConnection.rs["InitialStock"] = txtValues[0].Text;
      		modConnection.rs["DateStarted"] = DateTimeHelper.ToString(DateTime.Today);
      		modConnection.rs["DateModified"] = DateTimeHelper.ToString(DateTime.Today);
      		modConnection.rs["User"] = modMain.UserId;
      		modConnection.rs["UnitPrice"] = txtValues[2].Text;
      		modConnection.rs["StockPrice"] = txtValues[1].Text;
      		modConnection.rs.Update();
      		modConnection.ExecuteSql("SELECT last_insert_rowid()");
      		newStockId = Convert.ToInt32(modConnection.rs[0]);

      		modConnection.ExecuteSql("Select * from ManualStocks");
      		modConnection.rs.AddNew();
      		modConnection.rs["StockID"] = newStockId;
      		modConnection.rs["Quantity"] = txtValues[0].Text;
      		modConnection.rs["Price"] = txtValues[1].Text;
      		modConnection.rs["User"] = modMain.UserId;
      		modConnection.rs["Date"] = DateTimeHelper.ToString(DateTime.Today);
      		modConnection.rs["Action"] = "ADD";
      		modConnection.rs.Update();
      		modConnection.ExecuteSql("SELECT last_insert_rowid()");
      		newManualLogId = Convert.ToInt32(modConnection.rs[0]);

      		modConnection.ExecuteSql("Select * from StockLog");
      		modConnection.rs.AddNew();
      		modConnection.rs["User"] = modMain.UserId;
      		modConnection.rs["Date"] = DateTimeHelper.ToString(DateTime.Today);
      		modConnection.rs["Quantity"] = txtValues[0].Text;
      		modConnection.rs["StockPrice"] = txtValues[1].Text;
      		modConnection.rs["ProductID"] = currentIdProduct;
      		modConnection.rs["StockID"] = newStockId;
      		modConnection.rs["DocType"] = "MANUAL";
      		modConnection.rs["DocID"] = newManualLogId;
      		modConnection.rs.Update();
      		modConnection.ExecuteSql("SELECT last_insert_rowid()");
      		newStockLogId = Convert.ToInt32(modConnection.rs[0]);

      		modConnection.ExecuteSql("Update Products Set UnitsInStock = UnitsInStock + " + txtValues[0].Text +
      		                         " Where ProductId = '& currentIdProduct &'");

      		if ( Mobilize.Web.MessageBox.Show("Data added successfully" + Environment.NewLine + "Would you like to add a new stock manually?", "New data", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) == Mobilize.Web.DialogResult.Yes)
            {
            	ClearFields();
            }
            else
            {
            	this.Close();
            }
         }
         catch (System.Exception excep)
         {
            Mobilize.Web.MessageBox.Show("An error has occurred adding the data. Error: (" + Stub._Microsoft.VisualBasic.Information.Err().Number.ToString() + ") " + excep.Message, "Error", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
         }

      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080

      private void Form_Load()
      {
      	editingData = false;
      	codeGeneratedChange = false;
      }

      private void Form_FormClosing(Object eventSender, Mobilize.Web.FormClosingEventArgs eventArgs)
      {
      	int Cancel = (eventArgs.Cancel) ? 1 : 0;
      	int UnloadMode = (int) eventArgs.CloseReason;
      	try
      	{
            Mobilize.Web.DialogResult res = (Mobilize.Web.DialogResult) 0;
            if (editingData)
            {
            	res = Mobilize.Web.MessageBox.Show("Do you want to save the edited data?", "Save data", Mobilize.Web.MessageBoxButtons.YesNoCancel, Mobilize.Web.MessageBoxIcon.Question);
               if (res == Mobilize.Web.DialogResult.Yes)
               {
               	cmdSave_Click(cmdSave, new EventArgs());
               }
               else if (res != Mobilize.Web.DialogResult.No)
               {
               	Cancel = -1;
               }
            }
         }
         finally
         {
            eventArgs.Cancel = Cancel != 0;
         }
      }

      private void lvProducts_Click(Object eventSender, EventArgs eventArgs)
      {
      	RetrieveDataProduct();
      }

      private void lvProducts_ItemClick(Mobilize.Web.ListViewItem Item)
      {
      	RetrieveDataProduct();
      }

      private void txtCode_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchProduct();
      }

      //Private Sub txtCode_KeyPress(KeyAscii As Integer)
      //KeyAscii = UpCase(KeyAscii)
      //End Sub

      private void txtCode_Leave(Object eventSender, EventArgs eventArgs)
      {
      	if (lvProducts.Items.Count == 1)
         {
         	RetrieveDataProduct();
         }
      }

      private void txtName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchProduct();
      }


      private void DoSearchProduct()
      {
      	string filter = "";
      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!String.IsNullOrEmpty(txtCode.Text))
      	{
      		filter = "ProductId LIKE '%" + txtCode.Text + "%'";
      	}
      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!String.IsNullOrEmpty(txtName.Text))
      	{
      		//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      		if (!String.IsNullOrEmpty(filter))
      		{
      			filter = filter + " AND ";
      		}
      		filter = filter + "ProductName LIKE '%" + txtName.Text + "%'";
      	}
      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!String.IsNullOrEmpty(filter))
      	{
      		filter = "Where " + filter;
      	}
      	modConnection.ExecuteSql("Select ProductID, ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, QuantityPerUnit, Unit from Products " + filter);
      	lvProducts.Items.Clear();
         Mobilize.Web.ListViewItem x = null;
         if (modConnection.rs.RecordCount == 0)
         {
         	modMain.LogStatus("There are no records with the selected criteria", this);
         }
         else
         {
         	while (!modConnection.rs.EOF)
         	{
         		x = lvProducts.Items.Add(Convert.ToString(modConnection.rs[0]));
         		int tempForEndVar = (modConnection.rs.FieldsMetadata.Count - 1);
         		for (modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++)
         		{
         			//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         			if (modConnection.rs.GetField(modMain.i) != null)
                  {
                     Mobilize.Web.ListView.GetListViewSubItem(x, modMain.i).Text = Convert.ToString(modConnection.rs[modMain.i]);
                  }
               }
               modConnection.rs.MoveNext();
            }
            if (lvProducts.Items.Count == 1)
            {
            	lvProducts.Items[0].Selected = true;
            	//RetrieveDataProduct
            }
         }
      }

      private void RetrieveDataProduct()
      {
      	if (editingData)
      	{
      		if ( Mobilize.Web.MessageBox.Show("Do you want to cancel previous edited data?", "Data edition", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) != Mobilize.Web.DialogResult.Yes)
            {
            	return;
            }
         }
         Mobilize.Web.ListViewItem withVar = null;
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (lvProducts.FocusedItem != null)
         {
         	withVar = lvProducts.FocusedItem;
         	currentIdProduct = lvProducts.FocusedItem.Text;
         	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         	if (!String.IsNullOrEmpty(Mobilize.Web.ListView.GetListViewSubItem(withVar, 5).Text))
            {
            	currentQuantityPerUnit = Mobilize.Web.ListView.GetListViewSubItem(withVar, 5).Text;
            }
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
            if (!String.IsNullOrEmpty(Mobilize.Web.ListView.GetListViewSubItem(withVar, 6).Text))
            {
            	currentUnit = Mobilize.Web.ListView.GetListViewSubItem(withVar, 6).Text;
            }
            currentProductName = Mobilize.Web.ListView.GetListViewSubItem(withVar, 1).Text;
            currentPriceReference = Double.Parse(Mobilize.Web.ListView.GetListViewSubItem(withVar, 2).Text);
            txtProductName.Text = currentProductName;
            txtQuantityPerUnit.Text = currentQuantityPerUnit;
            txtUnit.Text = currentUnit;
            txtValues[0].ReadOnly = false;
            txtValues[1].ReadOnly = false;
            txtValues[2].ReadOnly = false;
            txtValues[0].Text = "1";
            txtValues[1].Text = currentPriceReference.ToString();
            txtValues[2].Text = currentPriceReference.ToString();
            txtValues[0].Focus();
            modFunctions.SelectAll(txtValues[0]);
            editingData = false;
         }
      }


      private void txtName_Leave(Object eventSender, EventArgs eventArgs)
      {
      	if (lvProducts.Items.Count == 1)
         {
         	RetrieveDataProduct();
         }
      }

      private void txtValues_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	int Index = Array.IndexOf(this.txtValues, eventSender);
      	if (!codeGeneratedChange)
      	{
      		editingData = true;
      		codeGeneratedChange = true;
      		//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      		if (!String.IsNullOrEmpty(txtValues[0].Text))
      		{
      			quantity = Double.Parse(txtValues[0].Text);
      		}
      		//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      		if (!String.IsNullOrEmpty(txtValues[1].Text))
      		{
      			stockPrice = Double.Parse(txtValues[1].Text);
      		}
      		//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      		if (!String.IsNullOrEmpty(txtValues[2].Text))
      		{
      			unitPrice = Double.Parse(txtValues[2].Text);
      		}
      		switch(Index)
      		{
      			case 0 : case 2 :
      				txtValues[1].Text = (unitPrice * quantity).ToString();
      				break;
      			case 1 :
      				txtValues[2].Text = (stockPrice / quantity).ToString();
      				break;
      		}
      		lblNewQuantity.Text = StringsHelper.Format(quantity * Double.Parse(currentQuantityPerUnit), "##,###.00") + currentUnit;
      		codeGeneratedChange = false;
      	}
      }

      private void txtValues_Enter(Object eventSender, EventArgs eventArgs)
      {
      	int Index = Array.IndexOf(this.txtValues, eventSender);
      	modFunctions.SelectAll(txtValues[Index]);
      }

      private void txtValues_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
      {
      	int KeyAscii = Strings.Asc(eventArgs.KeyChar);
      	try
      	{
      		if (KeyAscii >= ((int)Mobilize.Web.Keys.D0) && KeyAscii <= ((int)Mobilize.Web.Keys.D9))
            {
            }
            else if (KeyAscii == ((int)Mobilize.Web.Keys.Back) || KeyAscii == ((int)Mobilize.Web.Keys.Clear) || KeyAscii == ((int)Mobilize.Web.Keys.Delete))
            {
            }
            else if (KeyAscii == ((int)Mobilize.Web.Keys.Left) || KeyAscii == ((int)Mobilize.Web.Keys.Right) || KeyAscii == ((int)Mobilize.Web.Keys.Up) || KeyAscii == ((int)Mobilize.Web.Keys.Down) || KeyAscii == ((int)Mobilize.Web.Keys.Tab))
            {
            }
            else
            {
            	KeyAscii = 0;
               Stub._System.Media.SystemSounds.Beep.Play();
            }
         }
         finally
         {
            if (KeyAscii == 0)
            {
            	eventArgs.Handled = true;
            }
            eventArgs.KeyChar = Convert.ToChar(KeyAscii);
         }
      }

      private void ClearFields()
      {
      	codeGeneratedChange = true;
      	txtValues[0].ReadOnly = true;
      	txtValues[1].ReadOnly = true;
      	txtValues[2].ReadOnly = true;
      	txtValues[0].Text = "";
      	txtValues[1].Text = "";
      	txtValues[2].Text = "";
      	txtCode.Text = "";
      	txtName.Text = "";
      	txtUnit.Text = "";
      	txtProductName.Text = "";
      	txtQuantityPerUnit.Text = "";
      	lvProducts.Items.Clear();
      	txtCode.Focus();
      	editingData = false;
      	codeGeneratedChange = false;
      	lblNewQuantity.Text = "";
      	modMain.ClearLogStatus(this);
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }
public class _Mobilize_SharedState :Mobilize.WebMap.Common.Core.IObservable,Mobilize.WebMap.Common.Core.IDelta{
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[1];
Mobilize.WebMap.Common.Core.Identifier Mobilize.WebMap.Common.Core.IObservable.MobilizeId{get ;
set ;
}=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.IdentifierService.GetIdentifier();
Mobilize.WebMap.Common.Core.ReferenceMap Mobilize.WebMap.Common.Core.IObservable.References{
get =>this._Mobilize_GetReferenceMap(new Mobilize.WebMap.Common.Core.ReferenceMap());
set =>throw new System.NotImplementedException();
}

protected uint _Mobilize_ControlFlag=1;
bool Mobilize.WebMap.Common.Core.ITrackable.IsNew {get =>(this._Mobilize_ControlFlag&_Mobilize_IsNew_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<0:this._Mobilize_ControlFlag&0<<0;
}
Mobilize.WebMap.Common.Core.IDelta Mobilize.WebMap.Common.Core.ITrackable.Delta =>this;
void Mobilize.WebMap.Common.Core.ITrackable.CleanChanges ()=>_Mobilize_CleanChanges();
protected virtual void _Mobilize_CleanChanges ()
{if(!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew||((Mobilize.WebMap.Common.Core.IObservable)this).RefCount>0)
{this._Mobilize_DirtyFlag_0=0;
this._Mobilize_LoadedFlag_0=0;
this._Mobilize_ControlFlag=0;
}
}
protected virtual Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{refs["m_vb6FormDefInstance"]=_Mobilize_References[0];
return refs;
}
private int _Mobilize_RefCount=0;
int Mobilize.WebMap.Common.Core.IObservable.DecrementRefCount ()
{return System.Threading.Interlocked.Decrement(ref _Mobilize_RefCount);
}
int Mobilize.WebMap.Common.Core.IObservable.IncrementRefCount ()
{return System.Threading.Interlocked.Increment(ref _Mobilize_RefCount);
}
int Mobilize.WebMap.Common.Core.IObservable.RefCount{get
{return _Mobilize_RefCount;
}
}
System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> Mobilize.WebMap.Common.Core.IObservable.GetReferences()
{return this._Mobilize_GetReferences();
}
protected virtual System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences(){var ref_m_vb6FormDefInstance=(Mobilize.WebMap.Common.Core.IObservable)this.m_vb6FormDefInstance;if(ref_m_vb6FormDefInstance!=null)yield return ref_m_vb6FormDefInstance;
yield break ;
}
const uint _Mobilize_IsNew_Flag=(uint)1<<0;
protected const uint _Mobilize_HasChanged_Flag=(uint)1<<1;
bool Mobilize.WebMap.Common.Core.ITrackable.HasChanged{get =>(this._Mobilize_ControlFlag&_Mobilize_HasChanged_Flag)>0;
}
const uint _Mobilize_IsRefresh_Flag=(uint)1<<2;
bool Mobilize.WebMap.Common.Core.ITrackable.IsRefresh {get =>(this._Mobilize_ControlFlag&_Mobilize_IsRefresh_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<2:this._Mobilize_ControlFlag&0<<2;
}
const uint _Mobilize_IsMarked_Flag=(uint)1<<3;
bool Mobilize.WebMap.Common.Core.ITrackable.IsMarked {get =>(this._Mobilize_ControlFlag&_Mobilize_IsMarked_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<3:this._Mobilize_ControlFlag&0<<3;
}
bool Mobilize.WebMap.Common.Core.IDelta.IsNew{get =>(this._Mobilize_ControlFlag&_Mobilize_IsNew_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<0:this._Mobilize_ControlFlag&0<<0;
}
Mobilize.WebMap.Common.Core.IObservable Mobilize.WebMap.Common.Core.IDelta.Target{get =>this;
set =>throw new System.NotImplementedException();
}
System.Collections.Generic.IEnumerable<string> Mobilize.WebMap.Common.Core.IDelta.Changes=>this._Mobilize_GetChanges();
bool Mobilize.WebMap.Common.Core.IDelta.HasChanges(string propertyName)=>this._Mobilize_HasChanges(propertyName);
protected virtual System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_vb6FormDefInstance)>0)
{yield return "m_vb6FormDefInstance";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_InitializingDefInstance)>0)
{yield return "m_InitializingDefInstance";
}
yield break ;
}
protected virtual bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "m_vb6FormDefInstance":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_vb6FormDefInstance)>0;
case "m_InitializingDefInstance":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_InitializingDefInstance)>0;
}return false;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_m_vb6FormDefInstance=(uint)1<<0;
const uint _Mobilize_Loaded_m_vb6FormDefInstance=(uint)1<<0;
const uint _Mobilize_Dirty_m_InitializingDefInstance=(uint)1<<1;

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private SKS.frmAddStockManual m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmAddStockManual>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmAddStockManual>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmAddStockManual)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmAddStockManual)value;}}
#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool m_InitializingDefInstance_k__BackingField;
internal bool m_InitializingDefInstance {get
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.m_InitializingDefInstance_k__BackingField;}set
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_InitializingDefInstance;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_InitializingDefInstance_k__BackingField=(bool)value;}}}
   }
}
#pragma warning restore