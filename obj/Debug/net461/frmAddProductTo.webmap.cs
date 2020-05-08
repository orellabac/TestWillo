#pragma warning disable
#line 1 "frmAddProductTo.cs"
#pragma warning disable
#line 1 "frmAddProductTo.cs"
using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmAddProductTo
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[33];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Id)>0)
{yield return "Id";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ObjectReferred)>0)
{yield return "ObjectReferred";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Table)>0)
{yield return "Table";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ColumnName)>0)
{yield return "ColumnName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_SavedChanges)>0)
{yield return "SavedChanges";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_productsStored)>0)
{yield return "productsStored";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_productsToDelete)>0)
{yield return "productsToDelete";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_productsToAdd)>0)
{yield return "productsToAdd";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_editingData)>0)
{yield return "editingData";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentIdProduct)>0)
{yield return "currentIdProduct";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_codeGeneratedChange)>0)
{yield return "codeGeneratedChange";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_chkAll)>0)
{yield return "chkAll";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdRemove)>0)
{yield return "cmdRemove";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0)
{yield return "sbStatusBar_Panels_Panel1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0)
{yield return "sbStatusBar";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0)
{yield return "cmdClose";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSave)>0)
{yield return "cmdSave";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_1_)>0)
{yield return "lvProducts_ColumnHeader_1_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_2_)>0)
{yield return "lvProducts_ColumnHeader_2_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_3_)>0)
{yield return "lvProducts_ColumnHeader_3_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_4_)>0)
{yield return "lvProducts_ColumnHeader_4_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_5_)>0)
{yield return "lvProducts_ColumnHeader_5_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_6_)>0)
{yield return "lvProducts_ColumnHeader_6_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_7_)>0)
{yield return "lvProducts_ColumnHeader_7_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts)>0)
{yield return "lvProducts";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0)
{yield return "Label4";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label5)>0)
{yield return "Label5";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame1)>0)
{yield return "Frame1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy_ColumnHeader_1_)>0)
{yield return "lvProductsBy_ColumnHeader_1_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy_ColumnHeader_2_)>0)
{yield return "lvProductsBy_ColumnHeader_2_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy_ColumnHeader_3_)>0)
{yield return "lvProductsBy_ColumnHeader_3_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy_ColumnHeader_4_)>0)
{yield return "lvProductsBy_ColumnHeader_4_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy)>0)
{yield return "lvProductsBy";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lblProductsRelated)>0)
{yield return "lblProductsRelated";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_listViewHelper1)>0)
{yield return "listViewHelper1";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "Id":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Id)>0;
case "ObjectReferred":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ObjectReferred)>0;
case "Table":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Table)>0;
case "ColumnName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ColumnName)>0;
case "SavedChanges":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_SavedChanges)>0;
case "productsStored":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_productsStored)>0;
case "productsToDelete":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_productsToDelete)>0;
case "productsToAdd":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_productsToAdd)>0;
case "editingData":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_editingData)>0;
case "currentIdProduct":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentIdProduct)>0;
case "codeGeneratedChange":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_codeGeneratedChange)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "chkAll":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_chkAll)>0;
case "cmdRemove":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdRemove)>0;
case "sbStatusBar_Panels_Panel1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0;
case "sbStatusBar":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0;
case "cmdClose":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0;
case "cmdSave":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSave)>0;
case "cmdProducts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdProducts)>0;
case "txtName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtName)>0;
case "txtCode":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtCode)>0;
case "lvProducts_ColumnHeader_1_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_1_)>0;
case "lvProducts_ColumnHeader_2_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_2_)>0;
case "lvProducts_ColumnHeader_3_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_3_)>0;
case "lvProducts_ColumnHeader_4_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_4_)>0;
case "lvProducts_ColumnHeader_5_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_5_)>0;
case "lvProducts_ColumnHeader_6_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_6_)>0;
case "lvProducts_ColumnHeader_7_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts_ColumnHeader_7_)>0;
case "lvProducts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProducts)>0;
case "Label4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0;
case "Label5":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label5)>0;
case "Frame1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame1)>0;
case "lvProductsBy_ColumnHeader_1_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy_ColumnHeader_1_)>0;
case "lvProductsBy_ColumnHeader_2_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy_ColumnHeader_2_)>0;
case "lvProductsBy_ColumnHeader_3_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy_ColumnHeader_3_)>0;
case "lvProductsBy_ColumnHeader_4_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy_ColumnHeader_4_)>0;
case "lvProductsBy":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProductsBy)>0;
case "lblProductsRelated":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lblProductsRelated)>0;
case "listViewHelper1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_listViewHelper1)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["productsStored"]=_Mobilize_References[0];
refs["productsToDelete"]=_Mobilize_References[1];
refs["productsToAdd"]=_Mobilize_References[2];
refs["visualControls"]=_Mobilize_References[3];
refs["components"]=_Mobilize_References[4];
refs["ToolTipMain"]=_Mobilize_References[5];
refs["chkAll"]=_Mobilize_References[6];
refs["cmdRemove"]=_Mobilize_References[7];
refs["sbStatusBar_Panels_Panel1"]=_Mobilize_References[8];
refs["sbStatusBar"]=_Mobilize_References[9];
refs["cmdClose"]=_Mobilize_References[10];
refs["cmdSave"]=_Mobilize_References[11];
refs["cmdProducts"]=_Mobilize_References[12];
refs["txtName"]=_Mobilize_References[13];
refs["txtCode"]=_Mobilize_References[14];
refs["lvProducts_ColumnHeader_1_"]=_Mobilize_References[15];
refs["lvProducts_ColumnHeader_2_"]=_Mobilize_References[16];
refs["lvProducts_ColumnHeader_3_"]=_Mobilize_References[17];
refs["lvProducts_ColumnHeader_4_"]=_Mobilize_References[18];
refs["lvProducts_ColumnHeader_5_"]=_Mobilize_References[19];
refs["lvProducts_ColumnHeader_6_"]=_Mobilize_References[20];
refs["lvProducts_ColumnHeader_7_"]=_Mobilize_References[21];
refs["lvProducts"]=_Mobilize_References[22];
refs["Label4"]=_Mobilize_References[23];
refs["Label5"]=_Mobilize_References[24];
refs["Frame1"]=_Mobilize_References[25];
refs["lvProductsBy_ColumnHeader_1_"]=_Mobilize_References[26];
refs["lvProductsBy_ColumnHeader_2_"]=_Mobilize_References[27];
refs["lvProductsBy_ColumnHeader_3_"]=_Mobilize_References[28];
refs["lvProductsBy_ColumnHeader_4_"]=_Mobilize_References[29];
refs["lvProductsBy"]=_Mobilize_References[30];
refs["lblProductsRelated"]=_Mobilize_References[31];
refs["listViewHelper1"]=_Mobilize_References[32];
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
}var ref_productsStored=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.productsStored);if(ref_productsStored!=null)yield return ref_productsStored;
var ref_productsToDelete=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.productsToDelete);if(ref_productsToDelete!=null)yield return ref_productsToDelete;
var ref_productsToAdd=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.productsToAdd);if(ref_productsToAdd!=null)yield return ref_productsToAdd;
var ref_visualControls=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.visualControls);if(ref_visualControls!=null)yield return ref_visualControls;
var ref_components=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.components);if(ref_components!=null)yield return ref_components;
var ref_ToolTipMain=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.ToolTipMain);if(ref_ToolTipMain!=null)yield return ref_ToolTipMain;
var ref_chkAll=(Mobilize.WebMap.Common.Core.IObservable)this.chkAll;if(ref_chkAll!=null)yield return ref_chkAll;
var ref_cmdRemove=(Mobilize.WebMap.Common.Core.IObservable)this.cmdRemove;if(ref_cmdRemove!=null)yield return ref_cmdRemove;
var ref_sbStatusBar_Panels_Panel1=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar_Panels_Panel1;if(ref_sbStatusBar_Panels_Panel1!=null)yield return ref_sbStatusBar_Panels_Panel1;
var ref_sbStatusBar=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar;if(ref_sbStatusBar!=null)yield return ref_sbStatusBar;
var ref_cmdClose=(Mobilize.WebMap.Common.Core.IObservable)this.cmdClose;if(ref_cmdClose!=null)yield return ref_cmdClose;
var ref_cmdSave=(Mobilize.WebMap.Common.Core.IObservable)this.cmdSave;if(ref_cmdSave!=null)yield return ref_cmdSave;
var ref_cmdProducts=(Mobilize.WebMap.Common.Core.IObservable)this.cmdProducts;if(ref_cmdProducts!=null)yield return ref_cmdProducts;
var ref_txtName=(Mobilize.WebMap.Common.Core.IObservable)this.txtName;if(ref_txtName!=null)yield return ref_txtName;
var ref_txtCode=(Mobilize.WebMap.Common.Core.IObservable)this.txtCode;if(ref_txtCode!=null)yield return ref_txtCode;
var ref_lvProducts_ColumnHeader_1_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_1_;if(ref_lvProducts_ColumnHeader_1_!=null)yield return ref_lvProducts_ColumnHeader_1_;
var ref_lvProducts_ColumnHeader_2_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_2_;if(ref_lvProducts_ColumnHeader_2_!=null)yield return ref_lvProducts_ColumnHeader_2_;
var ref_lvProducts_ColumnHeader_3_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_3_;if(ref_lvProducts_ColumnHeader_3_!=null)yield return ref_lvProducts_ColumnHeader_3_;
var ref_lvProducts_ColumnHeader_4_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_4_;if(ref_lvProducts_ColumnHeader_4_!=null)yield return ref_lvProducts_ColumnHeader_4_;
var ref_lvProducts_ColumnHeader_5_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_5_;if(ref_lvProducts_ColumnHeader_5_!=null)yield return ref_lvProducts_ColumnHeader_5_;
var ref_lvProducts_ColumnHeader_6_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_6_;if(ref_lvProducts_ColumnHeader_6_!=null)yield return ref_lvProducts_ColumnHeader_6_;
var ref_lvProducts_ColumnHeader_7_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts_ColumnHeader_7_;if(ref_lvProducts_ColumnHeader_7_!=null)yield return ref_lvProducts_ColumnHeader_7_;
var ref_lvProducts=(Mobilize.WebMap.Common.Core.IObservable)this.lvProducts;if(ref_lvProducts!=null)yield return ref_lvProducts;
var ref_Label4=(Mobilize.WebMap.Common.Core.IObservable)this.Label4;if(ref_Label4!=null)yield return ref_Label4;
var ref_Label5=(Mobilize.WebMap.Common.Core.IObservable)this.Label5;if(ref_Label5!=null)yield return ref_Label5;
var ref_Frame1=(Mobilize.WebMap.Common.Core.IObservable)this.Frame1;if(ref_Frame1!=null)yield return ref_Frame1;
var ref_lvProductsBy_ColumnHeader_1_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProductsBy_ColumnHeader_1_;if(ref_lvProductsBy_ColumnHeader_1_!=null)yield return ref_lvProductsBy_ColumnHeader_1_;
var ref_lvProductsBy_ColumnHeader_2_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProductsBy_ColumnHeader_2_;if(ref_lvProductsBy_ColumnHeader_2_!=null)yield return ref_lvProductsBy_ColumnHeader_2_;
var ref_lvProductsBy_ColumnHeader_3_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProductsBy_ColumnHeader_3_;if(ref_lvProductsBy_ColumnHeader_3_!=null)yield return ref_lvProductsBy_ColumnHeader_3_;
var ref_lvProductsBy_ColumnHeader_4_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProductsBy_ColumnHeader_4_;if(ref_lvProductsBy_ColumnHeader_4_!=null)yield return ref_lvProductsBy_ColumnHeader_4_;
var ref_lvProductsBy=(Mobilize.WebMap.Common.Core.IObservable)this.lvProductsBy;if(ref_lvProductsBy!=null)yield return ref_lvProductsBy;
var ref_lblProductsRelated=(Mobilize.WebMap.Common.Core.IObservable)this.lblProductsRelated;if(ref_lblProductsRelated!=null)yield return ref_lblProductsRelated;
var ref_listViewHelper1=(Mobilize.WebMap.Common.Core.IObservable)this.listViewHelper1;if(ref_listViewHelper1!=null)yield return ref_listViewHelper1;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_DirtyFlag_1;
private uint _Mobilize_LoadedFlag_0;
private uint _Mobilize_LoadedFlag_1;
const uint _Mobilize_Dirty_Id=(uint)1<<0;
const uint _Mobilize_Dirty_ObjectReferred=(uint)1<<1;
const uint _Mobilize_Dirty_Table=(uint)1<<2;
const uint _Mobilize_Dirty_ColumnName=(uint)1<<3;
const uint _Mobilize_Dirty_SavedChanges=(uint)1<<4;
const uint _Mobilize_Dirty_productsStored=(uint)1<<5;
const uint _Mobilize_Loaded_productsStored=(uint)1<<0;
const uint _Mobilize_Dirty_productsToDelete=(uint)1<<6;
const uint _Mobilize_Loaded_productsToDelete=(uint)1<<1;
const uint _Mobilize_Dirty_productsToAdd=(uint)1<<7;
const uint _Mobilize_Loaded_productsToAdd=(uint)1<<2;
const uint _Mobilize_Dirty_editingData=(uint)1<<8;
const uint _Mobilize_Dirty_currentIdProduct=(uint)1<<9;
const uint _Mobilize_Dirty_codeGeneratedChange=(uint)1<<10;
const uint _Mobilize_Dirty_visualControls=(uint)1<<11;
const uint _Mobilize_Loaded_visualControls=(uint)1<<3;
const uint _Mobilize_Dirty_components=(uint)1<<12;
const uint _Mobilize_Loaded_components=(uint)1<<4;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<13;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<5;
const uint _Mobilize_Dirty_chkAll=(uint)1<<14;
const uint _Mobilize_Loaded_chkAll=(uint)1<<6;
const uint _Mobilize_Dirty_cmdRemove=(uint)1<<15;
const uint _Mobilize_Loaded_cmdRemove=(uint)1<<7;
const uint _Mobilize_Dirty_sbStatusBar_Panels_Panel1=(uint)1<<16;
const uint _Mobilize_Loaded_sbStatusBar_Panels_Panel1=(uint)1<<8;
const uint _Mobilize_Dirty_sbStatusBar=(uint)1<<17;
const uint _Mobilize_Loaded_sbStatusBar=(uint)1<<9;
const uint _Mobilize_Dirty_cmdClose=(uint)1<<18;
const uint _Mobilize_Loaded_cmdClose=(uint)1<<10;
const uint _Mobilize_Dirty_cmdSave=(uint)1<<19;
const uint _Mobilize_Loaded_cmdSave=(uint)1<<11;
const uint _Mobilize_Dirty_cmdProducts=(uint)1<<20;
const uint _Mobilize_Loaded_cmdProducts=(uint)1<<12;
const uint _Mobilize_Dirty_txtName=(uint)1<<21;
const uint _Mobilize_Loaded_txtName=(uint)1<<13;
const uint _Mobilize_Dirty_txtCode=(uint)1<<22;
const uint _Mobilize_Loaded_txtCode=(uint)1<<14;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_1_=(uint)1<<23;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_1_=(uint)1<<15;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_2_=(uint)1<<24;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_2_=(uint)1<<16;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_3_=(uint)1<<25;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_3_=(uint)1<<17;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_4_=(uint)1<<26;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_4_=(uint)1<<18;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_5_=(uint)1<<27;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_5_=(uint)1<<19;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_6_=(uint)1<<28;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_6_=(uint)1<<20;
const uint _Mobilize_Dirty_lvProducts_ColumnHeader_7_=(uint)1<<29;
const uint _Mobilize_Loaded_lvProducts_ColumnHeader_7_=(uint)1<<21;
const uint _Mobilize_Dirty_lvProducts=(uint)1<<30;
const uint _Mobilize_Loaded_lvProducts=(uint)1<<22;
const uint _Mobilize_Dirty_Label4=(uint)1<<31;
const uint _Mobilize_Loaded_Label4=(uint)1<<23;
const uint _Mobilize_Dirty_Label5=(uint)1<<32;
const uint _Mobilize_Loaded_Label5=(uint)1<<24;
const uint _Mobilize_Dirty_Frame1=(uint)1<<33;
const uint _Mobilize_Loaded_Frame1=(uint)1<<25;
const uint _Mobilize_Dirty_lvProductsBy_ColumnHeader_1_=(uint)1<<34;
const uint _Mobilize_Loaded_lvProductsBy_ColumnHeader_1_=(uint)1<<26;
const uint _Mobilize_Dirty_lvProductsBy_ColumnHeader_2_=(uint)1<<35;
const uint _Mobilize_Loaded_lvProductsBy_ColumnHeader_2_=(uint)1<<27;
const uint _Mobilize_Dirty_lvProductsBy_ColumnHeader_3_=(uint)1<<36;
const uint _Mobilize_Loaded_lvProductsBy_ColumnHeader_3_=(uint)1<<28;
const uint _Mobilize_Dirty_lvProductsBy_ColumnHeader_4_=(uint)1<<37;
const uint _Mobilize_Loaded_lvProductsBy_ColumnHeader_4_=(uint)1<<29;
const uint _Mobilize_Dirty_lvProductsBy=(uint)1<<38;
const uint _Mobilize_Loaded_lvProductsBy=(uint)1<<30;
const uint _Mobilize_Dirty_lblProductsRelated=(uint)1<<39;
const uint _Mobilize_Loaded_lblProductsRelated=(uint)1<<31;
const uint _Mobilize_Dirty_listViewHelper1=(uint)1<<40;
const uint _Mobilize_Loaded_listViewHelper1=(uint)1<<32;
private void Mobilize_Initialize_Properties()
{
#line 19
                                  this.Id=0;
#line hidden
 
#line 22
                                                 this.ObjectReferred="";
#line hidden
 
#line 25
                                        this.Table="";
#line hidden
 
#line 28
                                             this.ColumnName="";
#line hidden
 
#line 32
                                             this.SavedChanges=false;
#line hidden
 
#line 35
                                                             this.productsStored=null;
#line hidden
 
#line 38
                                                               this.productsToDelete=null;
#line hidden
 
#line 41
                                                            this.productsToAdd=null;
#line hidden
 
#line 44
                                             this.editingData=false;
#line hidden
 
#line 47
                                                    this.currentIdProduct="";
#line hidden
 
#line 51
                                                     this.codeGeneratedChange=false;
#line hidden
 
#line 47
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "chkAll", "cmdRemove", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdClose", "cmdSave", "cmdProducts", "txtName", "txtCode", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "Label4", "Label5", "Frame1", "lvProductsBy_ColumnHeader_1_", "lvProductsBy_ColumnHeader_2_", "lvProductsBy_ColumnHeader_3_", "lvProductsBy_ColumnHeader_4_", "lvProductsBy", "lblProductsRelated", "listViewHelper1"};
#line hidden
 }
#line 14
    

#line hidden
                                  
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Id_k__BackingField;
#line 19
                                  

      [Intercepted]


      public int Id 
#line 19
                    { 
#line 19
                      get                         
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Id_k__BackingField;} 
#line 19

#line 19
                           set                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Id;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Id_k__BackingField=(int)value;} 
#line 19
                                } 
#line 20

#line hidden
                                                 
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string ObjectReferred_k__BackingField;
#line 22
                                                 

      [Intercepted]
      public string ObjectReferred 
#line 22
                                   { 
#line 22
                                     get                                        
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ObjectReferred_k__BackingField;} 
#line 22

#line 22
                                          set                                             
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ObjectReferred;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ObjectReferred_k__BackingField=(string)value;} 
#line 22
                                               } 
#line 23

#line hidden
                                        
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Table_k__BackingField;
#line 25
                                        

      [Intercepted]
      public string Table 
#line 25
                          { 
#line 25
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Table_k__BackingField;} 
#line 25

#line 25
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Table;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Table_k__BackingField=(string)value;} 
#line 25
                                      } 
#line 26

#line hidden
                                             
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string ColumnName_k__BackingField;
#line 28
                                             

      [Intercepted]
      public string ColumnName 
#line 28
                               { 
#line 28
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ColumnName_k__BackingField;} 
#line 28

#line 28
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ColumnName;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ColumnName_k__BackingField=(string)value;} 
#line 28
                                           } 
#line 29

#line hidden
                                             
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool SavedChanges_k__BackingField;
#line 32
                                             

      [Intercepted]

      public bool SavedChanges 
#line 32
                               { 
#line 32
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.SavedChanges_k__BackingField;} 
#line 32

#line 32
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_SavedChanges;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.SavedChanges_k__BackingField=(bool)value;} 
#line 32
                                           } 
#line 33

#line hidden
                                                             
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Collections.Specialized.OrderedDictionary productsStored_k__BackingField;
#line 35
                                                             

      [Intercepted]
      private OrderedDictionary productsStored 
#line 35
                                               { 
#line 35
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_productsStored)<=0){this.productsStored_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Collections.Specialized.OrderedDictionary>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_productsStored;}return this.productsStored_k__BackingField;} 
#line 35

#line 35
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<OrderedDictionary >(this,_Mobilize_References,0,this.productsStored_k__BackingField,(System.Collections.Specialized.OrderedDictionary)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_productsStored;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_productsStored;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.productsStored_k__BackingField=(System.Collections.Specialized.OrderedDictionary)value;} 
#line 35
                                                           } 
#line 36

#line hidden
                                                               
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Collections.Specialized.OrderedDictionary productsToDelete_k__BackingField;
#line 38
                                                               

      [Intercepted]
      private OrderedDictionary productsToDelete 
#line 38
                                                 { 
#line 38
                                                   get                                                      
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_productsToDelete)<=0){this.productsToDelete_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Collections.Specialized.OrderedDictionary>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_productsToDelete;}return this.productsToDelete_k__BackingField;} 
#line 38

#line 38
                                                        set                                                           
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<OrderedDictionary >(this,_Mobilize_References,1,this.productsToDelete_k__BackingField,(System.Collections.Specialized.OrderedDictionary)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_productsToDelete;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_productsToDelete;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.productsToDelete_k__BackingField=(System.Collections.Specialized.OrderedDictionary)value;} 
#line 38
                                                             } 
#line 39

#line hidden
                                                            
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Collections.Specialized.OrderedDictionary productsToAdd_k__BackingField;
#line 41
                                                            

      [Intercepted]
      private OrderedDictionary productsToAdd 
#line 41
                                              { 
#line 41
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_productsToAdd)<=0){this.productsToAdd_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Collections.Specialized.OrderedDictionary>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_productsToAdd;}return this.productsToAdd_k__BackingField;} 
#line 41

#line 41
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<OrderedDictionary >(this,_Mobilize_References,2,this.productsToAdd_k__BackingField,(System.Collections.Specialized.OrderedDictionary)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_productsToAdd;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_productsToAdd;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.productsToAdd_k__BackingField=(System.Collections.Specialized.OrderedDictionary)value;} 
#line 41
                                                          } 
#line 42

#line hidden
                                             
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool editingData_k__BackingField;
#line 44
                                             

      [Intercepted]
      private bool editingData 
#line 44
                               { 
#line 44
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.editingData_k__BackingField;} 
#line 44

#line 44
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_editingData;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.editingData_k__BackingField=(bool)value;} 
#line 44
                                           } 
#line 45

#line hidden
                                                    
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string currentIdProduct_k__BackingField;
#line 47
                                                    

      [Intercepted]
      private string currentIdProduct 
#line 47
                                      { 
#line 47
                                        get                                           
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentIdProduct_k__BackingField;} 
#line 47

#line 47
                                             set                                                
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentIdProduct;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentIdProduct_k__BackingField=(string)value;} 
#line 47
                                                  } 
#line 48

#line hidden
                                                     
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool codeGeneratedChange_k__BackingField;
#line 51
                                                     

      [Intercepted]

      private bool codeGeneratedChange 
#line 51
                                       { 
#line 51
                                         get                                            
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.codeGeneratedChange_k__BackingField;} 
#line 51

#line 51
                                              set                                                 
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_codeGeneratedChange;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.codeGeneratedChange_k__BackingField=(bool)value;} 
#line 51
                                                   } 
#line 52


      public frmAddProductTo()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 56
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
      }



      private void chkAll_CheckStateChanged(Object eventSender, EventArgs eventArgs)
      {
      	bool check = chkAll.CheckState == Mobilize.Web.CheckState.Checked;
         int tempForEndVar = lvProductsBy.Items.Count;
         for (modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++)
         {
         	lvProductsBy.Items[modMain.i - 1].Checked = check;
         }
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

      private void cmdRemove_Click(Object eventSender, EventArgs eventArgs)
      {
      	string productIdToDelete = "";
      	for (modMain.i = lvProductsBy.Items.Count; modMain.i >= 1; modMain.i--)
      	{
      		if (lvProductsBy.Items[modMain.i - 1].Checked)
      		{
      			productIdToDelete = lvProductsBy.Items[modMain.i - 1].Text;

      			if (modFunctions.Exists(productsStored, productIdToDelete))
      			{
      				if (modFunctions.Exists(productsToAdd, productIdToDelete))
      				{
      					productsToDelete.Remove(productIdToDelete);
      				}
      				else
      				{
      					modFunctions.AddToCollection(productsToDelete, productIdToDelete);
      				}
      			}
      			else
      			{
      				if (modFunctions.Exists(productsToAdd, currentIdProduct))
      				{
      					productsToAdd.Remove(currentIdProduct);
      				}
      			}

      			lvProductsBy.Items.RemoveAt(modMain.i - 1);
      			editingData = true;
      		}
      	}
      }

      private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
      {

      	if (productsToAdd.Count == 0 && productsToDelete.Count == 0)
         {
         	editingData = true;
            Mobilize.Web.MessageBox.Show("No data to be saved", "No data modified", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
            this.Close();
            return;
         }
         SavedChanges = true;
         foreach (string productCode in productsToAdd.Values)
         {
            modConnection.ExecuteSql("Insert into " + Table + "(" + ColumnName + ", ProductID) Values (" + Id.ToString() + ", '" + productCode + "')");
         }
         foreach (string productCode in productsToDelete.Values)
         {
            modConnection.ExecuteSql("Delete from " + Table + " Where " + ColumnName + " = " + Id.ToString() + " And ProductID = '" + productCode + "'");
         }

         editingData = false;
         Mobilize.Web.MessageBox.Show("Data was succesfully saved", "New data", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
         this.Close();
         return;
         Mobilize.Web.MessageBox.Show("An error has occurred adding the data. Error: (" + Stub._Microsoft.VisualBasic.Information.Err().Number.ToString() + ") " + Stub._Microsoft.VisualBasic.Information.Err().Description, "Error", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
      }

      public void LoadData()
      {
      	editingData = false;
      	editingData = false;
      	codeGeneratedChange = false;
      	this.Text = "Add product(s) to " + ObjectReferred;
      	lblProductsRelated.Text = "Products related to " + ObjectReferred;
      	productsStored = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
      	productsToDelete = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
      	productsToAdd = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
      	LoadProductsById();
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

      private void lvProducts_ItemClick(Mobilize.Web.ListViewItem Item)
      {
      	AddProductToSet();
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
         	AddProductToSet();
         }
      }

      private void txtName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchProduct();
      }

      private void LoadProductsById()
      {
      	string productCode = "";
      	modConnection.ExecuteSql("Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit, p.Unit from Products as p, " + Table + " as pb Where pb." + ColumnName + " = " + Id.ToString() + " And pb.ProductId = p.ProductId");

      	modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
         Mobilize.Web.ListViewItem x = null;
         if (modConnection.rs.RecordCount > 0)
         {
         	while (!modConnection.rs.EOF)
         	{
         		//productCode = CStr(rs.Fields(0).value)
         		productCode = Convert.ToString(modConnection.rs[0]);
         		modFunctions.AddToCollection(productsStored, productCode);
         		x = lvProductsBy.Items.Add(productCode);
         		for (modMain.i = 1; modMain.i <= 2; modMain.i++)
         		{
         			//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         			if (modConnection.rs.GetField(modMain.i) != null)
                  {
                     Mobilize.Web.ListView.GetListViewSubItem(x, modMain.i).Text = Convert.ToString(modConnection.rs[modMain.i]);
                  }
               }
               Mobilize.Web.ListView.GetListViewSubItem(x, 3).Text = Convert.ToString(modConnection.rs[3]) + Convert.ToString(modConnection.rs[4]);
               modConnection.rs.MoveNext();
            }
         }
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
      	modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
         Mobilize.Web.ListViewItem x = null;
         if (modConnection.rs.RecordCount > 0)
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
            }
         }
      }

      private void AddProductToSet()
      {
         Mobilize.Web.ListViewItem y = null;
         int i = 0;
         bool found = false;
         Mobilize.Web.ListViewItem x = null;
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (lvProducts.FocusedItem != null)
         {
         	y = lvProducts.FocusedItem;
         	currentIdProduct = lvProducts.FocusedItem.Text;
         	found = false;
         	int tempForEndVar = lvProductsBy.Items.Count;
         	for (i = 1; i <= tempForEndVar; i++)
         	{
         		if (lvProductsBy.Items[i - 1].Text == currentIdProduct)
               {
               	lvProductsBy.Items[i - 1].Selected = true;
               	found = true;
               	break;
               }
               else if (String.CompareOrdinal(lvProductsBy.Items[i - 1].Text, currentIdProduct) > 0)
               {
               	break;
               }
            }
            if (!found)
            {
               editingData = true;
               if (!modFunctions.Exists(productsStored, currentIdProduct))
               {
               	if (modFunctions.Exists(productsToDelete, currentIdProduct))
               	{
               		productsToDelete.Remove(currentIdProduct);
               	}
               	else
               	{
               		modFunctions.AddToCollection(productsToAdd, currentIdProduct);
               	}
               }
               else
               {
               	if (modFunctions.Exists(productsToDelete, currentIdProduct))
               	{
               		productsToDelete.Remove(currentIdProduct);
               	}
               }
               x = lvProductsBy.Items.Insert(i - 1, currentIdProduct);
               Mobilize.Web.ListView.GetListViewSubItem(x, 1).Text = Mobilize.Web.ListView.GetListViewSubItem(y, 1).Text;
               Mobilize.Web.ListView.GetListViewSubItem(x, 2).Text = Mobilize.Web.ListView.GetListViewSubItem(y, 2).Text;
               Mobilize.Web.ListView.GetListViewSubItem(x, 3).Text = Mobilize.Web.ListView.GetListViewSubItem(y, 5).Text + Mobilize.Web.ListView.GetListViewSubItem(y, 6).Text;
            }
         }
      }

      //UPGRADE_NOTE: (7001) The following declaration (ClearFields) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
      //private void ClearFields()
      //{
      	//codeGeneratedChange = true;
      	//txtCode.Text = "";
      	//txtName.Text = "";
      	//lvProducts.Items.Clear();
      	//lvProductsBy.Items.Clear();
      	//txtCode.Focus();
      	//editingData = false;
      	//codeGeneratedChange = false;
      //}

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
private SKS.frmAddProductTo m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmAddProductTo>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmAddProductTo>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmAddProductTo)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmAddProductTo)value;}}
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
