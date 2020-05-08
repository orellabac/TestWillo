#pragma warning disable
#line 1 "frmOrderReception.cs"
#pragma warning disable
#line 1 "frmOrderReception.cs"
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
   internal partial class frmOrderReception
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[45];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentProviderName)>0)
{yield return "currentProviderName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentIdProvider)>0)
{yield return "currentIdProvider";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentContactName)>0)
{yield return "currentContactName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_editingData)>0)
{yield return "editingData";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentSubTotal)>0)
{yield return "currentSubTotal";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTotal)>0)
{yield return "currentTotal";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTax)>0)
{yield return "currentTax";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentFreightCharge)>0)
{yield return "currentFreightCharge";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTotalTax)>0)
{yield return "currentTotalTax";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtNotes)>0)
{yield return "txtNotes";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtSubTotal)>0)
{yield return "txtSubTotal";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtTotal)>0)
{yield return "txtTotal";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtTotalTax)>0)
{yield return "txtTotalTax";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtFreightCharge)>0)
{yield return "txtFreightCharge";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtSalesTax)>0)
{yield return "txtSalesTax";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtEntry)>0)
{yield return "txtEntry";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_fgProducts)>0)
{yield return "fgProducts";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0)
{yield return "sbStatusBar_Panels_Panel1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0)
{yield return "sbStatusBar";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSave)>0)
{yield return "cmdSave";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0)
{yield return "cmdClose";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdAddProducts)>0)
{yield return "cmdAddProducts";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProviderName)>0)
{yield return "txtProviderName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtContactLastName)>0)
{yield return "txtContactLastName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtContactName)>0)
{yield return "txtContactName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdProviders)>0)
{yield return "cmdProviders";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProviders_ColumnHeader_1_)>0)
{yield return "lvProviders_ColumnHeader_1_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProviders_ColumnHeader_2_)>0)
{yield return "lvProviders_ColumnHeader_2_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProviders_ColumnHeader_3_)>0)
{yield return "lvProviders_ColumnHeader_3_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders_ColumnHeader_4_)>0)
{yield return "lvProviders_ColumnHeader_4_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders_ColumnHeader_5_)>0)
{yield return "lvProviders_ColumnHeader_5_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders_ColumnHeader_6_)>0)
{yield return "lvProviders_ColumnHeader_6_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders_ColumnHeader_7_)>0)
{yield return "lvProviders_ColumnHeader_7_";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders)>0)
{yield return "lvProviders";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label3)>0)
{yield return "Label3";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label4)>0)
{yield return "Label4";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label2)>0)
{yield return "Label2";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame1)>0)
{yield return "Frame1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtProviderContact)>0)
{yield return "txtProviderContact";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtProviderCompany)>0)
{yield return "txtProviderCompany";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label5)>0)
{yield return "Label5";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label1)>0)
{yield return "Label1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame2)>0)
{yield return "Frame2";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label7)>0)
{yield return "Label7";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label12)>0)
{yield return "Label12";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label11)>0)
{yield return "Label11";
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
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label6)>0)
{yield return "Label6";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_listViewHelper1)>0)
{yield return "listViewHelper1";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "currentProviderName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentProviderName)>0;
case "currentIdProvider":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentIdProvider)>0;
case "currentContactName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentContactName)>0;
case "editingData":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_editingData)>0;
case "currentSubTotal":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentSubTotal)>0;
case "currentTotal":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTotal)>0;
case "currentTax":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTax)>0;
case "currentFreightCharge":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentFreightCharge)>0;
case "currentTotalTax":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTotalTax)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "txtNotes":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtNotes)>0;
case "txtSubTotal":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtSubTotal)>0;
case "txtTotal":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtTotal)>0;
case "txtTotalTax":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtTotalTax)>0;
case "txtFreightCharge":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtFreightCharge)>0;
case "txtSalesTax":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtSalesTax)>0;
case "txtEntry":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtEntry)>0;
case "fgProducts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_fgProducts)>0;
case "sbStatusBar_Panels_Panel1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0;
case "sbStatusBar":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0;
case "cmdSave":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSave)>0;
case "cmdClose":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0;
case "cmdAddProducts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdAddProducts)>0;
case "txtProviderName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProviderName)>0;
case "txtContactLastName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtContactLastName)>0;
case "txtContactName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtContactName)>0;
case "cmdProviders":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdProviders)>0;
case "lvProviders_ColumnHeader_1_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProviders_ColumnHeader_1_)>0;
case "lvProviders_ColumnHeader_2_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProviders_ColumnHeader_2_)>0;
case "lvProviders_ColumnHeader_3_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lvProviders_ColumnHeader_3_)>0;
case "lvProviders_ColumnHeader_4_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders_ColumnHeader_4_)>0;
case "lvProviders_ColumnHeader_5_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders_ColumnHeader_5_)>0;
case "lvProviders_ColumnHeader_6_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders_ColumnHeader_6_)>0;
case "lvProviders_ColumnHeader_7_":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders_ColumnHeader_7_)>0;
case "lvProviders":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lvProviders)>0;
case "Label3":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label3)>0;
case "Label4":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label4)>0;
case "Label2":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label2)>0;
case "Frame1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame1)>0;
case "txtProviderContact":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtProviderContact)>0;
case "txtProviderCompany":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtProviderCompany)>0;
case "Label5":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label5)>0;
case "Label1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label1)>0;
case "Frame2":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame2)>0;
case "Label7":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label7)>0;
case "Label12":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label12)>0;
case "Label11":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label11)>0;
case "Label10":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label10)>0;
case "Label9":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label9)>0;
case "Label8":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label8)>0;
case "Label6":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label6)>0;
case "listViewHelper1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_listViewHelper1)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["txtNotes"]=_Mobilize_References[3];
refs["txtSubTotal"]=_Mobilize_References[4];
refs["txtTotal"]=_Mobilize_References[5];
refs["txtTotalTax"]=_Mobilize_References[6];
refs["txtFreightCharge"]=_Mobilize_References[7];
refs["txtSalesTax"]=_Mobilize_References[8];
refs["txtEntry"]=_Mobilize_References[9];
refs["fgProducts"]=_Mobilize_References[10];
refs["sbStatusBar_Panels_Panel1"]=_Mobilize_References[11];
refs["sbStatusBar"]=_Mobilize_References[12];
refs["cmdSave"]=_Mobilize_References[13];
refs["cmdClose"]=_Mobilize_References[14];
refs["cmdAddProducts"]=_Mobilize_References[15];
refs["txtProviderName"]=_Mobilize_References[16];
refs["txtContactLastName"]=_Mobilize_References[17];
refs["txtContactName"]=_Mobilize_References[18];
refs["cmdProviders"]=_Mobilize_References[19];
refs["lvProviders_ColumnHeader_1_"]=_Mobilize_References[20];
refs["lvProviders_ColumnHeader_2_"]=_Mobilize_References[21];
refs["lvProviders_ColumnHeader_3_"]=_Mobilize_References[22];
refs["lvProviders_ColumnHeader_4_"]=_Mobilize_References[23];
refs["lvProviders_ColumnHeader_5_"]=_Mobilize_References[24];
refs["lvProviders_ColumnHeader_6_"]=_Mobilize_References[25];
refs["lvProviders_ColumnHeader_7_"]=_Mobilize_References[26];
refs["lvProviders"]=_Mobilize_References[27];
refs["Label3"]=_Mobilize_References[28];
refs["Label4"]=_Mobilize_References[29];
refs["Label2"]=_Mobilize_References[30];
refs["Frame1"]=_Mobilize_References[31];
refs["txtProviderContact"]=_Mobilize_References[32];
refs["txtProviderCompany"]=_Mobilize_References[33];
refs["Label5"]=_Mobilize_References[34];
refs["Label1"]=_Mobilize_References[35];
refs["Frame2"]=_Mobilize_References[36];
refs["Label7"]=_Mobilize_References[37];
refs["Label12"]=_Mobilize_References[38];
refs["Label11"]=_Mobilize_References[39];
refs["Label10"]=_Mobilize_References[40];
refs["Label9"]=_Mobilize_References[41];
refs["Label8"]=_Mobilize_References[42];
refs["Label6"]=_Mobilize_References[43];
refs["listViewHelper1"]=_Mobilize_References[44];
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
var ref_txtNotes=(Mobilize.WebMap.Common.Core.IObservable)this.txtNotes;if(ref_txtNotes!=null)yield return ref_txtNotes;
var ref_txtSubTotal=(Mobilize.WebMap.Common.Core.IObservable)this.txtSubTotal;if(ref_txtSubTotal!=null)yield return ref_txtSubTotal;
var ref_txtTotal=(Mobilize.WebMap.Common.Core.IObservable)this.txtTotal;if(ref_txtTotal!=null)yield return ref_txtTotal;
var ref_txtTotalTax=(Mobilize.WebMap.Common.Core.IObservable)this.txtTotalTax;if(ref_txtTotalTax!=null)yield return ref_txtTotalTax;
var ref_txtFreightCharge=(Mobilize.WebMap.Common.Core.IObservable)this.txtFreightCharge;if(ref_txtFreightCharge!=null)yield return ref_txtFreightCharge;
var ref_txtSalesTax=(Mobilize.WebMap.Common.Core.IObservable)this.txtSalesTax;if(ref_txtSalesTax!=null)yield return ref_txtSalesTax;
var ref_txtEntry=(Mobilize.WebMap.Common.Core.IObservable)this.txtEntry;if(ref_txtEntry!=null)yield return ref_txtEntry;
var ref_fgProducts=(Mobilize.WebMap.Common.Core.IObservable)this.fgProducts;if(ref_fgProducts!=null)yield return ref_fgProducts;
var ref_sbStatusBar_Panels_Panel1=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar_Panels_Panel1;if(ref_sbStatusBar_Panels_Panel1!=null)yield return ref_sbStatusBar_Panels_Panel1;
var ref_sbStatusBar=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar;if(ref_sbStatusBar!=null)yield return ref_sbStatusBar;
var ref_cmdSave=(Mobilize.WebMap.Common.Core.IObservable)this.cmdSave;if(ref_cmdSave!=null)yield return ref_cmdSave;
var ref_cmdClose=(Mobilize.WebMap.Common.Core.IObservable)this.cmdClose;if(ref_cmdClose!=null)yield return ref_cmdClose;
var ref_cmdAddProducts=(Mobilize.WebMap.Common.Core.IObservable)this.cmdAddProducts;if(ref_cmdAddProducts!=null)yield return ref_cmdAddProducts;
var ref_txtProviderName=(Mobilize.WebMap.Common.Core.IObservable)this.txtProviderName;if(ref_txtProviderName!=null)yield return ref_txtProviderName;
var ref_txtContactLastName=(Mobilize.WebMap.Common.Core.IObservable)this.txtContactLastName;if(ref_txtContactLastName!=null)yield return ref_txtContactLastName;
var ref_txtContactName=(Mobilize.WebMap.Common.Core.IObservable)this.txtContactName;if(ref_txtContactName!=null)yield return ref_txtContactName;
var ref_cmdProviders=(Mobilize.WebMap.Common.Core.IObservable)this.cmdProviders;if(ref_cmdProviders!=null)yield return ref_cmdProviders;
var ref_lvProviders_ColumnHeader_1_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProviders_ColumnHeader_1_;if(ref_lvProviders_ColumnHeader_1_!=null)yield return ref_lvProviders_ColumnHeader_1_;
var ref_lvProviders_ColumnHeader_2_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProviders_ColumnHeader_2_;if(ref_lvProviders_ColumnHeader_2_!=null)yield return ref_lvProviders_ColumnHeader_2_;
var ref_lvProviders_ColumnHeader_3_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProviders_ColumnHeader_3_;if(ref_lvProviders_ColumnHeader_3_!=null)yield return ref_lvProviders_ColumnHeader_3_;
var ref_lvProviders_ColumnHeader_4_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProviders_ColumnHeader_4_;if(ref_lvProviders_ColumnHeader_4_!=null)yield return ref_lvProviders_ColumnHeader_4_;
var ref_lvProviders_ColumnHeader_5_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProviders_ColumnHeader_5_;if(ref_lvProviders_ColumnHeader_5_!=null)yield return ref_lvProviders_ColumnHeader_5_;
var ref_lvProviders_ColumnHeader_6_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProviders_ColumnHeader_6_;if(ref_lvProviders_ColumnHeader_6_!=null)yield return ref_lvProviders_ColumnHeader_6_;
var ref_lvProviders_ColumnHeader_7_=(Mobilize.WebMap.Common.Core.IObservable)this.lvProviders_ColumnHeader_7_;if(ref_lvProviders_ColumnHeader_7_!=null)yield return ref_lvProviders_ColumnHeader_7_;
var ref_lvProviders=(Mobilize.WebMap.Common.Core.IObservable)this.lvProviders;if(ref_lvProviders!=null)yield return ref_lvProviders;
var ref_Label3=(Mobilize.WebMap.Common.Core.IObservable)this.Label3;if(ref_Label3!=null)yield return ref_Label3;
var ref_Label4=(Mobilize.WebMap.Common.Core.IObservable)this.Label4;if(ref_Label4!=null)yield return ref_Label4;
var ref_Label2=(Mobilize.WebMap.Common.Core.IObservable)this.Label2;if(ref_Label2!=null)yield return ref_Label2;
var ref_Frame1=(Mobilize.WebMap.Common.Core.IObservable)this.Frame1;if(ref_Frame1!=null)yield return ref_Frame1;
var ref_txtProviderContact=(Mobilize.WebMap.Common.Core.IObservable)this.txtProviderContact;if(ref_txtProviderContact!=null)yield return ref_txtProviderContact;
var ref_txtProviderCompany=(Mobilize.WebMap.Common.Core.IObservable)this.txtProviderCompany;if(ref_txtProviderCompany!=null)yield return ref_txtProviderCompany;
var ref_Label5=(Mobilize.WebMap.Common.Core.IObservable)this.Label5;if(ref_Label5!=null)yield return ref_Label5;
var ref_Label1=(Mobilize.WebMap.Common.Core.IObservable)this.Label1;if(ref_Label1!=null)yield return ref_Label1;
var ref_Frame2=(Mobilize.WebMap.Common.Core.IObservable)this.Frame2;if(ref_Frame2!=null)yield return ref_Frame2;
var ref_Label7=(Mobilize.WebMap.Common.Core.IObservable)this.Label7;if(ref_Label7!=null)yield return ref_Label7;
var ref_Label12=(Mobilize.WebMap.Common.Core.IObservable)this.Label12;if(ref_Label12!=null)yield return ref_Label12;
var ref_Label11=(Mobilize.WebMap.Common.Core.IObservable)this.Label11;if(ref_Label11!=null)yield return ref_Label11;
var ref_Label10=(Mobilize.WebMap.Common.Core.IObservable)this.Label10;if(ref_Label10!=null)yield return ref_Label10;
var ref_Label9=(Mobilize.WebMap.Common.Core.IObservable)this.Label9;if(ref_Label9!=null)yield return ref_Label9;
var ref_Label8=(Mobilize.WebMap.Common.Core.IObservable)this.Label8;if(ref_Label8!=null)yield return ref_Label8;
var ref_Label6=(Mobilize.WebMap.Common.Core.IObservable)this.Label6;if(ref_Label6!=null)yield return ref_Label6;
var ref_listViewHelper1=(Mobilize.WebMap.Common.Core.IObservable)this.listViewHelper1;if(ref_listViewHelper1!=null)yield return ref_listViewHelper1;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_DirtyFlag_1;
private uint _Mobilize_LoadedFlag_0;
private uint _Mobilize_LoadedFlag_1;
const uint _Mobilize_Dirty_currentProviderName=(uint)1<<0;
const uint _Mobilize_Dirty_currentIdProvider=(uint)1<<1;
const uint _Mobilize_Dirty_currentContactName=(uint)1<<2;
const uint _Mobilize_Dirty_editingData=(uint)1<<3;
const uint _Mobilize_Dirty_currentSubTotal=(uint)1<<4;
const uint _Mobilize_Dirty_currentTotal=(uint)1<<5;
const uint _Mobilize_Dirty_currentTax=(uint)1<<6;
const uint _Mobilize_Dirty_currentFreightCharge=(uint)1<<7;
const uint _Mobilize_Dirty_currentTotalTax=(uint)1<<8;
const uint _Mobilize_Dirty_visualControls=(uint)1<<9;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<10;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<11;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_txtNotes=(uint)1<<12;
const uint _Mobilize_Loaded_txtNotes=(uint)1<<3;
const uint _Mobilize_Dirty_txtSubTotal=(uint)1<<13;
const uint _Mobilize_Loaded_txtSubTotal=(uint)1<<4;
const uint _Mobilize_Dirty_txtTotal=(uint)1<<14;
const uint _Mobilize_Loaded_txtTotal=(uint)1<<5;
const uint _Mobilize_Dirty_txtTotalTax=(uint)1<<15;
const uint _Mobilize_Loaded_txtTotalTax=(uint)1<<6;
const uint _Mobilize_Dirty_txtFreightCharge=(uint)1<<16;
const uint _Mobilize_Loaded_txtFreightCharge=(uint)1<<7;
const uint _Mobilize_Dirty_txtSalesTax=(uint)1<<17;
const uint _Mobilize_Loaded_txtSalesTax=(uint)1<<8;
const uint _Mobilize_Dirty_txtEntry=(uint)1<<18;
const uint _Mobilize_Loaded_txtEntry=(uint)1<<9;
const uint _Mobilize_Dirty_fgProducts=(uint)1<<19;
const uint _Mobilize_Loaded_fgProducts=(uint)1<<10;
const uint _Mobilize_Dirty_sbStatusBar_Panels_Panel1=(uint)1<<20;
const uint _Mobilize_Loaded_sbStatusBar_Panels_Panel1=(uint)1<<11;
const uint _Mobilize_Dirty_sbStatusBar=(uint)1<<21;
const uint _Mobilize_Loaded_sbStatusBar=(uint)1<<12;
const uint _Mobilize_Dirty_cmdSave=(uint)1<<22;
const uint _Mobilize_Loaded_cmdSave=(uint)1<<13;
const uint _Mobilize_Dirty_cmdClose=(uint)1<<23;
const uint _Mobilize_Loaded_cmdClose=(uint)1<<14;
const uint _Mobilize_Dirty_cmdAddProducts=(uint)1<<24;
const uint _Mobilize_Loaded_cmdAddProducts=(uint)1<<15;
const uint _Mobilize_Dirty_txtProviderName=(uint)1<<25;
const uint _Mobilize_Loaded_txtProviderName=(uint)1<<16;
const uint _Mobilize_Dirty_txtContactLastName=(uint)1<<26;
const uint _Mobilize_Loaded_txtContactLastName=(uint)1<<17;
const uint _Mobilize_Dirty_txtContactName=(uint)1<<27;
const uint _Mobilize_Loaded_txtContactName=(uint)1<<18;
const uint _Mobilize_Dirty_cmdProviders=(uint)1<<28;
const uint _Mobilize_Loaded_cmdProviders=(uint)1<<19;
const uint _Mobilize_Dirty_lvProviders_ColumnHeader_1_=(uint)1<<29;
const uint _Mobilize_Loaded_lvProviders_ColumnHeader_1_=(uint)1<<20;
const uint _Mobilize_Dirty_lvProviders_ColumnHeader_2_=(uint)1<<30;
const uint _Mobilize_Loaded_lvProviders_ColumnHeader_2_=(uint)1<<21;
const uint _Mobilize_Dirty_lvProviders_ColumnHeader_3_=(uint)1<<31;
const uint _Mobilize_Loaded_lvProviders_ColumnHeader_3_=(uint)1<<22;
const uint _Mobilize_Dirty_lvProviders_ColumnHeader_4_=(uint)1<<32;
const uint _Mobilize_Loaded_lvProviders_ColumnHeader_4_=(uint)1<<23;
const uint _Mobilize_Dirty_lvProviders_ColumnHeader_5_=(uint)1<<33;
const uint _Mobilize_Loaded_lvProviders_ColumnHeader_5_=(uint)1<<24;
const uint _Mobilize_Dirty_lvProviders_ColumnHeader_6_=(uint)1<<34;
const uint _Mobilize_Loaded_lvProviders_ColumnHeader_6_=(uint)1<<25;
const uint _Mobilize_Dirty_lvProviders_ColumnHeader_7_=(uint)1<<35;
const uint _Mobilize_Loaded_lvProviders_ColumnHeader_7_=(uint)1<<26;
const uint _Mobilize_Dirty_lvProviders=(uint)1<<36;
const uint _Mobilize_Loaded_lvProviders=(uint)1<<27;
const uint _Mobilize_Dirty_Label3=(uint)1<<37;
const uint _Mobilize_Loaded_Label3=(uint)1<<28;
const uint _Mobilize_Dirty_Label4=(uint)1<<38;
const uint _Mobilize_Loaded_Label4=(uint)1<<29;
const uint _Mobilize_Dirty_Label2=(uint)1<<39;
const uint _Mobilize_Loaded_Label2=(uint)1<<30;
const uint _Mobilize_Dirty_Frame1=(uint)1<<40;
const uint _Mobilize_Loaded_Frame1=(uint)1<<31;
const uint _Mobilize_Dirty_txtProviderContact=(uint)1<<41;
const uint _Mobilize_Loaded_txtProviderContact=(uint)1<<32;
const uint _Mobilize_Dirty_txtProviderCompany=(uint)1<<42;
const uint _Mobilize_Loaded_txtProviderCompany=(uint)1<<33;
const uint _Mobilize_Dirty_Label5=(uint)1<<43;
const uint _Mobilize_Loaded_Label5=(uint)1<<34;
const uint _Mobilize_Dirty_Label1=(uint)1<<44;
const uint _Mobilize_Loaded_Label1=(uint)1<<35;
const uint _Mobilize_Dirty_Frame2=(uint)1<<45;
const uint _Mobilize_Loaded_Frame2=(uint)1<<36;
const uint _Mobilize_Dirty_Label7=(uint)1<<46;
const uint _Mobilize_Loaded_Label7=(uint)1<<37;
const uint _Mobilize_Dirty_Label12=(uint)1<<47;
const uint _Mobilize_Loaded_Label12=(uint)1<<38;
const uint _Mobilize_Dirty_Label11=(uint)1<<48;
const uint _Mobilize_Loaded_Label11=(uint)1<<39;
const uint _Mobilize_Dirty_Label10=(uint)1<<49;
const uint _Mobilize_Loaded_Label10=(uint)1<<40;
const uint _Mobilize_Dirty_Label9=(uint)1<<50;
const uint _Mobilize_Loaded_Label9=(uint)1<<41;
const uint _Mobilize_Dirty_Label8=(uint)1<<51;
const uint _Mobilize_Loaded_Label8=(uint)1<<42;
const uint _Mobilize_Dirty_Label6=(uint)1<<52;
const uint _Mobilize_Loaded_Label6=(uint)1<<43;
const uint _Mobilize_Dirty_listViewHelper1=(uint)1<<53;
const uint _Mobilize_Loaded_listViewHelper1=(uint)1<<44;
private void Mobilize_Initialize_Properties()
{
#line 19
                                                       this.currentProviderName="";
#line hidden
 
#line 22
                                                  this.currentIdProvider=0;
#line hidden
 
#line 25
                                                      this.currentContactName="";
#line hidden
 
#line 28
                                             this.editingData=false;
#line hidden
 
#line 32
                                                   this.currentSubTotal=0;
#line hidden
 
#line 35
                                                this.currentTotal=0;
#line hidden
 
#line 38
                                              this.currentTax=0;
#line hidden
 
#line 41
                                                        this.currentFreightCharge=0;
#line hidden
 
#line 44
                                                   this.currentTotalTax=0;
#line hidden
 
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdSave", "cmdClose", "cmdAddProducts", "txtProviderName", "txtContactLastName", "txtContactName", "cmdProviders", "lvProviders_ColumnHeader_1_", "lvProviders_ColumnHeader_2_", "lvProviders_ColumnHeader_3_", "lvProviders_ColumnHeader_4_", "lvProviders_ColumnHeader_5_", "lvProviders_ColumnHeader_6_", "lvProviders_ColumnHeader_7_", "lvProviders", "Label3", "Label4", "Label2", "Frame1", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "listViewHelper1"};
#line hidden
 }
#line 15
    

#line hidden
                                                       
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string currentProviderName_k__BackingField;
#line 19
                                                       

      [Intercepted]

      private string currentProviderName 
#line 19
                                         { 
#line 19
                                           get                                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentProviderName_k__BackingField;} 
#line 19

#line 19
                                                set                                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentProviderName;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentProviderName_k__BackingField=(string)value;} 
#line 19
                                                     } 
#line 20

#line hidden
                                                  
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int currentIdProvider_k__BackingField;
#line 22
                                                  

      [Intercepted]
      private int currentIdProvider 
#line 22
                                    { 
#line 22
                                      get                                         
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentIdProvider_k__BackingField;} 
#line 22

#line 22
                                           set                                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentIdProvider;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentIdProvider_k__BackingField=(int)value;} 
#line 22
                                                } 
#line 23

#line hidden
                                                      
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string currentContactName_k__BackingField;
#line 25
                                                      

      [Intercepted]
      private string currentContactName 
#line 25
                                        { 
#line 25
                                          get                                             
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentContactName_k__BackingField;} 
#line 25

#line 25
                                               set                                                  
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentContactName;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentContactName_k__BackingField=(string)value;} 
#line 25
                                                    } 
#line 26

#line hidden
                                             
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool editingData_k__BackingField;
#line 28
                                             

      [Intercepted]
      private bool editingData 
#line 28
                               { 
#line 28
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.editingData_k__BackingField;} 
#line 28

#line 28
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_editingData;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.editingData_k__BackingField=(bool)value;} 
#line 28
                                           } 
#line 29

#line hidden
                                                   
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentSubTotal_k__BackingField;
#line 32
                                                   

      [Intercepted]

      private double currentSubTotal 
#line 32
                                     { 
#line 32
                                       get                                          
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentSubTotal_k__BackingField;} 
#line 32

#line 32
                                            set                                               
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentSubTotal;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentSubTotal_k__BackingField=(double)value;} 
#line 32
                                                 } 
#line 33

#line hidden
                                                
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentTotal_k__BackingField;
#line 35
                                                

      [Intercepted]
      private double currentTotal 
#line 35
                                  { 
#line 35
                                    get                                       
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentTotal_k__BackingField;} 
#line 35

#line 35
                                         set                                            
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentTotal;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentTotal_k__BackingField=(double)value;} 
#line 35
                                              } 
#line 36

#line hidden
                                              
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentTax_k__BackingField;
#line 38
                                              

      [Intercepted]
      private double currentTax 
#line 38
                                { 
#line 38
                                  get                                     
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentTax_k__BackingField;} 
#line 38

#line 38
                                       set                                          
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentTax;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentTax_k__BackingField=(double)value;} 
#line 38
                                            } 
#line 39

#line hidden
                                                        
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentFreightCharge_k__BackingField;
#line 41
                                                        

      [Intercepted]
      private double currentFreightCharge 
#line 41
                                          { 
#line 41
                                            get                                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentFreightCharge_k__BackingField;} 
#line 41

#line 41
                                                 set                                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentFreightCharge;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentFreightCharge_k__BackingField=(double)value;} 
#line 41
                                                      } 
#line 42

#line hidden
                                                   
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentTotalTax_k__BackingField;
#line 44
                                                   

      [Intercepted]
      private double currentTotalTax 
#line 44
                                     { 
#line 44
                                       get                                          
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentTotalTax_k__BackingField;} 
#line 44

#line 44
                                            set                                               
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentTotalTax;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentTotalTax_k__BackingField=(double)value;} 
#line 44
                                                 } 
#line 45


      public frmOrderReception()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 49
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



      private void cmdAddProducts_Click(Object eventSender, EventArgs eventArgs)
      {
      	frmAddProductTo.DefInstance.Id = currentIdProvider;
      	frmAddProductTo.DefInstance.ObjectReferred = "Provider " + txtProviderCompany.Text + "|" + txtProviderContact.Text;
      	frmAddProductTo.DefInstance.Table = "ProductsByProvider";
      	frmAddProductTo.DefInstance.ColumnName = "ProviderId";
      	frmAddProductTo.DefInstance.LoadData();
      	frmAddProductTo.DefInstance.ShowDialog();
      	if (frmAddProductTo.DefInstance.SavedChanges)
      	{
      		LoadProductsById();
      	}
      }

      //UPGRADE_NOTE: (7001) The following declaration (txtName_Change) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
      //private void txtName_Change()
      //{
      	//DoSearchProvider();
      //}

      private void DoSearchProvider(int Id = 0)
      {
      	string filter = "";
      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!Id.Equals(0))
      	{
      		filter = "ProviderID = " + Id.ToString();
      	}
      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!String.IsNullOrEmpty(txtProviderName.Text))
      	{
      		//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      		if (!String.IsNullOrEmpty(filter))
      		{
      			filter = filter + " AND ";
      		}
      		filter = "ProviderName LIKE '%" + txtProviderName.Text + "%'";
      	}
      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!String.IsNullOrEmpty(txtContactName.Text))
      	{
      		//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      		if (!String.IsNullOrEmpty(filter))
      		{
      			filter = filter + " AND ";
      		}
      		filter = filter + "ContactFirstName LIKE '%" + txtContactName.Text + "%'";
      	}
      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!String.IsNullOrEmpty(txtContactLastName.Text))
      	{
      		//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      		if (!String.IsNullOrEmpty(filter))
      		{
      			filter = filter + " AND ";
      		}
      		filter = filter + "ContactLastName LIKE '%" + txtContactLastName.Text + "%'";
      	}

      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!String.IsNullOrEmpty(filter))
      	{
      		filter = "Where " + filter;
      	}
      	modConnection.ExecuteSql("Select ProviderID, ProviderName, ContactFirstName, ContactLastName, City, StateOrProvince, 'Country/Region' From Providers " + filter);
      	lvProviders.Items.Clear();
         Mobilize.Web.ListViewItem x = null;
         if (modConnection.rs.RecordCount == 0)
         {
         	modMain.LogStatus("There are no records with the selected criteria", this);
         }
         else
         {
         	while (!modConnection.rs.EOF)
         	{
         		x = lvProviders.Items.Add(Convert.ToString(modConnection.rs[0]));
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
            if (lvProviders.Items.Count == 1)
            {
            	lvProviders.Items[0].Selected = true;
            }
         }
      }

      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
      	this.Close();
      }

      private void cmdProviders_Click(Object eventSender, EventArgs eventArgs)
      {
      	frmProviders.DefInstance.ShowDialog();
      	txtProviderName.Text = "";
      	txtContactLastName.Text = "";
      	txtContactName.Text = "";
      	DoSearchProvider(frmProviders.DefInstance.CurrentProviderID);
      }

      private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
      {
      	int newOrderId = 0;

      	try
      	{
      		modConnection.ExecuteSql("Select * from OrderReceptions");
      		modConnection.rs.AddNew();
      		modConnection.rs["ProviderId"] = currentIdProvider;
      		modConnection.rs["ReceivedBy"] = modMain.UserId;
      		modConnection.rs["OrderDate"] = DateTimeHelper.ToString(DateTime.Today);
      		modConnection.rs["Notes"] = txtNotes.Text;
      		modConnection.rs["FreightCharge"] = currentFreightCharge;
      		modConnection.rs["SalesTaxRate"] = currentTax * 0.01d;
      		modConnection.rs["Status"] = "RECEIVED";
      		modConnection.rs.Update();

      		modConnection.ExecuteSql("SELECT last_insert_rowid() ");
      		newOrderId = Convert.ToInt32(modConnection.rs[0]);

      		int tempForEndVar = fgProducts.RowsCount - 1;
      		for (modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++)
      		{
      			if (Convert.ToString(fgProducts[modMain.i, 0].Value) != "0")
               {
               	modConnection.ExecuteSql("Insert into OrderReceptionDetails (OrderID, ProductID, DateSold, Quantity, UnitPrice, SalePrice, SalesTax, LineTotal) Values (" + newOrderId.ToString() + ", '" + Convert.ToString(fgProducts[modMain.i, 1].Value) + "', '" + DateTime.Today.ToString("MM/dd/yyyy") + "'," + Convert.ToString(fgProducts[modMain.i, 0].Value) + "," + Convert.ToString(fgProducts[modMain.i, 3].Value) + "," + Convert.ToString(fgProducts[modMain.i, 4].Value) + "," + (currentTax * 0.01d).ToString() + "," + Convert.ToString(fgProducts[modMain.i, 4].Value) + ")");

               	//UnitsInTransit
               	//ExecuteSql "Update Products Set UnitsOnOrder = UnitsOnOrder + " & fgProducts.TextMatrix(i, 0) & _
               	//'" Where ProductId = '" & fgProducts.TextMatrix(i, 1) & "'"

               }
            }



            editingData = false;
            if ( Mobilize.Web.MessageBox.Show("Order reception added successfully" + Environment.NewLine + "Would you like to add a new order reception?", "New data", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) == Mobilize.Web.DialogResult.Yes)
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

      private void MakeTextBoxVisible(Mobilize.Web.TextBox txtBox, Mobilize.Web.VBUC.FlexGrid grid)
      {
      	txtBox.Text = Convert.ToString(grid[grid.CurrentRowIndex, grid.CurrentColumnIndex].Value);
      	//txtBox.Move .CellLeft + .Left, .CellTop + .Top, .CellWidth, .CellHeight
      	txtBox.Visible = true;
      	txtBox.Enabled = true;
      	//DoEvents
      	txtBox.Focus();
      	modFunctions.SelectAll(txtBox);
      }

      private void fgProducts_Click(Object eventSender, EventArgs eventArgs)
      {
      	if (fgProducts.CurrentColumnIndex != 0)
         {
         	return;
         }
         MakeTextBoxVisible(txtEntry, fgProducts);
      }

      //UPGRADE_WARNING: (2050) MSFlexGridLib.MSFlexGrid Event fgProducts.EnterCell was not upgraded. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2050

      private void fgProducts_EnterCell()
      {
      	SaveEdits();
      }

      private void fgProducts_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
      {
      	int KeyAscii = Strings.Asc(eventArgs.KeyChar);
      	try
      	{
      		if (fgProducts.CurrentColumnIndex != 0)
            {
            	if (KeyAscii == 0)
               {
               	eventArgs.Handled = true;
               }
               return;
            }
            if (KeyAscii == 46 || KeyAscii >= 48 && KeyAscii <= 57)
            {
            	//Case 45, 46, 47, 48 To 59, 65 To 90, 97 To 122
            	MakeTextBoxVisible(txtEntry, fgProducts);
            	txtEntry.Text = Strings.Chr(KeyAscii).ToString();
            	txtEntry.SelectionStart = 1;
            }
            else
            {
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

      private void txtEntry_KeyDown(Object eventSender, Mobilize.Web.KeyEventArgs eventArgs)
      {
      	int KeyCode = (int) eventArgs.KeyCode;
      	int Shift = ((int) eventArgs.KeyData) / 65536;
      	try
      	{
      		EditKeyCode(fgProducts, Mobilize.Web.ReferenceExtensions.Ref(() => txtEntry), KeyCode, Shift);
         }
         finally
         {
         	eventArgs.Handled = KeyCode == 0;
         }
      }

      private void EditKeyCode(Mobilize.Web.VBUC.FlexGrid grid, dynamic txtBox, int KeyCode, int Shift)
      {
      	switch(KeyCode)
      	{
      		case 27 :  //ESC 
      			txtBox.Text = "";
      			txtBox.Visible = false;
      			grid.Focus();
      			break;
      		case 13 :  //Return 
      			grid.Focus();
      			break;
      		case 37 :  //Left Arrow 
      			grid.Focus();
               Stub._System.Windows.Forms.Application.DoEvents();
               if (grid.CurrentColumnIndex > grid.FixedColumns)
               {
                  (
                  grid.CurrentColumnIndex)--;
               }
               break;
            case 38 :  //Up Arrow 
               grid.Focus();
               Stub._System.Windows.Forms.Application.DoEvents();
               if (grid.CurrentRowIndex > grid.FixedRows)
               {
                  (
                  grid.CurrentRowIndex)--;
               }
               break;
            case 39 :  //Right Arrow 
               grid.Focus();
               Stub._System.Windows.Forms.Application.DoEvents();
               if (grid.CurrentColumnIndex < grid.ColumnsCount - 1)
               {
                  (
                  grid.CurrentColumnIndex)++;
               }
               break;
            case 40 :  //Down Arrow 
               grid.Focus();
               Stub._System.Windows.Forms.Application.DoEvents();
               if (grid.CurrentRowIndex < grid.RowsCount - 1)
               {
                  (
                  grid.CurrentRowIndex)++;
               }
               break;
         }
      }

      private void txtEntry_Leave(Object eventSender, EventArgs eventArgs)
      {
      	SaveEdits();
      }


      private void fgProducts_CellLeave(Object eventSender, EventArgs eventArgs)
      {
      	SaveEdits();
      }

      private void txtEntry_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
      {
      	int KeyAscii = Strings.Asc(eventArgs.KeyChar);
      	try
      	{
      		if (KeyAscii == 46 || KeyAscii >= 48 && KeyAscii <= 57)
            {
            	//Alphanumeric
            	//Case 45, 46, 47, 48 To 59, 65 To 90, 97 To 122
            }
            else
            {
            	KeyAscii = 0;
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

      private void SaveEdits()
      {
      	if (!txtEntry.Visible || !modFunctions.ValidateTextBoxDouble(txtEntry, this) || !modFunctions.ValidateTextDouble(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 3].Value), this) || !modFunctions.ValidateTextDouble(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 4].Value), this))
      	{
      		return;
      	}
      	double previousLinePrice = modFunctions.DoubleValue(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 4].Value));
      	fgProducts[fgProducts.CurrentRowIndex, fgProducts.CurrentColumnIndex].Value = txtEntry.Text;
      	double lineQuantity = modFunctions.DoubleValue(txtEntry.Text);
      	double lineUnitPrice = modFunctions.DoubleValue(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 3].Value));
      	previousLinePrice = modFunctions.DoubleValue(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 4].Value));
      	double linePrice = lineQuantity * lineUnitPrice;
      	fgProducts[fgProducts.CurrentRowIndex, 4].Value = linePrice.ToString();
      	ReCalculateTotals(previousLinePrice, linePrice);
      	txtEntry.Visible = false;
      	editingData = true;
      }

      private void ReCalculateTotals(double previous, double current)
      {
      	currentSubTotal = currentSubTotal - previous + current;
      	currentTotalTax = currentSubTotal * currentTax * 0.01d;
      	currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax;
      	txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00");
      	txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00");
      	txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00");
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

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080

      private void Form_Load()
      {
      	editingData = false;
      	ClearFields();
      }

      private void lvProviders_ItemClick(Mobilize.Web.ListViewItem Item)
      {
      	RetrieveDataProvider();
      }

      private void RetrieveDataProvider()
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
         if (lvProviders.FocusedItem != null)
         {
         	withVar = lvProviders.FocusedItem;
         	currentIdProvider = Convert.ToInt32(Double.Parse(lvProviders.FocusedItem.Text));
         	currentProviderName = Mobilize.Web.ListView.GetListViewSubItem(withVar, 1).Text;
            currentContactName = Mobilize.Web.ListView.GetListViewSubItem(withVar, 2).Text + " " + Mobilize.Web.ListView.GetListViewSubItem(withVar, 3).Text;
            txtProviderCompany.Text = currentProviderName;
            txtProviderContact.Text = currentContactName;
            editingData = false;
         }
         LoadProductsById();
         cmdSave.Enabled = true;
         cmdAddProducts.Enabled = true;

      }

      private void LoadProductsById()
      {
      	string Table = "ProductsByProvider";
      	string ColumnName = "ProviderId";
      	int Id = currentIdProvider;

      	modConnection.ExecuteSql("Select p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.QuantityPerUnit, p.Unit from Products as p, " + Table + " as pb Where pb." + ColumnName + " = " + Id.ToString() + " And pb.ProductId = p.ProductId");

      	//lvProducts.ListItems.Clear
      	//If rs.RecordCount > 0 Then
      	//    With rs
      	//        While Not .EOF
      	//            Set x = lvProducts.ListItems.Add(, , 0)
      	//            For i = 1 To 5
      	//                If Not IsEmpty(.Fields(i - 1)) Then
      	//                    x.SubItems(i) = .Fields(i - 1)
      	//                End If
      	//            Next i
      	//            x.SubItems(6) = .Fields(5) & .Fields(6)
      	//            .MoveNext
      	//        Wend
      	//    End With
      	//End If

      	int i = 0;
      	fgProducts.ColumnsCount = 8;
      	fgProducts.FixedColumns = 0;
      	fgProducts.RowsCount = 0;
      	fgProducts.AddItem("Quantity" + "\t" + "Code" + "\t" + "Product" + "\t" + "UnitPrice" + "\t" + "Price" + "\t" + "Existence" + "\t" + "Ordered" + "\t" + "Quantity per unit");
      	fgProducts.RowsCount = modConnection.rs.RecordCount + 1;
      	if (fgProducts.RowsCount == 1)
         {
         	fgProducts.FixedRows = 0;
         }
         else
         {
         	fgProducts.FixedRows = 1;
         }
         i = 1;
         while (!modConnection.rs.EOF)
         {
         	fgProducts[i, 0].Value = "0";
         	for (int j = 1; j <= 6; j++)
         	{
         		if (j == 4)
               {
               	fgProducts[i, j].Value = "0";
               }
               else if (j < 4)
               {
               	fgProducts[i, j].Value = Convert.ToString(modConnection.rs[j - 1]);
               }
               else
               {
               	fgProducts[i, j].Value = Convert.ToString(modConnection.rs[j - 2]);
               }
            }
            fgProducts[i, 7].Value = Convert.ToString(modConnection.rs[5]) + Convert.ToString(modConnection.rs[6]);
            modConnection.rs.MoveNext();
            i++;
         }

      }


      //UPGRADE_NOTE: (7001) The following declaration (lvProducts_ItemCheck) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
      //private void lvProducts_ItemCheck(ListViewItem Item)
      //{
      	//if (Item.Checked)
      	//{
      		//Item.Text = "1";
      	//}
      	//else
      	//{
      		//Item.Text = "0";
      	//}
      //}


      private void txtProviderName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchProvider();
      }

      private void txtNotes_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	editingData = true;
      }

      private void txtContactName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchProvider();
      }

      private void ClearFields()
      {

      	fgProducts.RowsCount = 0;
      	fgProducts.ColumnsCount = 0;

      	currentSubTotal = 0;
      	currentTotal = 0;
      	currentTax = 0;
      	currentTotalTax = 0;
      	currentFreightCharge = 0;

      	txtSubTotal.Text = "";
      	txtTotal.Text = "";
      	txtTotalTax.Text = "";
      	txtSalesTax.Text = "";
      	txtFreightCharge.Text = "";

      	txtProviderName.Text = "";
      	txtContactLastName.Text = "";
      	txtContactName.Text = "";
      	txtProviderContact.Text = "";
      	txtProviderCompany.Text = "";
      	cmdSave.Enabled = false;
      	cmdAddProducts.Enabled = false;
      	txtNotes.Text = "";
      	//txtProviderName.SetFocus
      	ReCalculateTotals(0, 0);
      	editingData = false;
      }

      private void txtFreightCharge_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	currentFreightCharge = modFunctions.DoubleValue(txtFreightCharge.Text);
      	ReCalculateTotals(0, 0);
      	editingData = true;
      }

      private void txtFreightCharge_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
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

      private void txtContactLastName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	editingData = true;
      }


      private void txtSalesTax_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	currentTax = modFunctions.DoubleValue(txtSalesTax.Text);
      	ReCalculateTotals(0, 0);
      	editingData = true;
      }

      private void txtSalesTax_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
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
private SKS.frmOrderReception m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmOrderReception>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmOrderReception>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmOrderReception)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmOrderReception)value;}}
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
