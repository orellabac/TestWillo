#pragma warning disable
#line 1 "frmActionOrderReception.cs"
#pragma warning disable
#line 1 "frmActionOrderReception.cs"
using Microsoft.VisualBasic;
using System;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmActionOrderReception
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[39];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Action)>0)
{yield return "Action";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_OrderId)>0)
{yield return "OrderId";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtReceivedBy)>0)
{yield return "txtReceivedBy";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdApprove)>0)
{yield return "cmdApprove";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtStatus)>0)
{yield return "txtStatus";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtReceived)>0)
{yield return "txtReceived";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtChangedBy)>0)
{yield return "txtChangedBy";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtChanged)>0)
{yield return "txtChanged";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtOrderID)>0)
{yield return "txtOrderID";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_fgDetails)>0)
{yield return "fgDetails";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0)
{yield return "sbStatusBar_Panels_Panel1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0)
{yield return "sbStatusBar";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdCancel)>0)
{yield return "cmdCancel";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0)
{yield return "cmdClose";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProviderContact)>0)
{yield return "txtProviderContact";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProviderCompany)>0)
{yield return "txtProviderCompany";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label5)>0)
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
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label3)>0)
{yield return "Label3";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label19)>0)
{yield return "Label19";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lblChangedBy)>0)
{yield return "lblChangedBy";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label4)>0)
{yield return "Label4";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lblChanged)>0)
{yield return "lblChanged";
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
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "currentSubTotal":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentSubTotal)>0;
case "currentTotal":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTotal)>0;
case "currentTax":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTax)>0;
case "currentFreightCharge":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentFreightCharge)>0;
case "currentTotalTax":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_currentTotalTax)>0;
case "Action":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Action)>0;
case "OrderId":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_OrderId)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "txtReceivedBy":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtReceivedBy)>0;
case "cmdApprove":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdApprove)>0;
case "txtStatus":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtStatus)>0;
case "txtReceived":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtReceived)>0;
case "txtChangedBy":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtChangedBy)>0;
case "txtChanged":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtChanged)>0;
case "txtOrderID":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtOrderID)>0;
case "txtNotes":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtNotes)>0;
case "txtSubTotal":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtSubTotal)>0;
case "txtTotal":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtTotal)>0;
case "txtTotalTax":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtTotalTax)>0;
case "txtFreightCharge":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtFreightCharge)>0;
case "txtSalesTax":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtSalesTax)>0;
case "txtEntry":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtEntry)>0;
case "fgDetails":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_fgDetails)>0;
case "sbStatusBar_Panels_Panel1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0;
case "sbStatusBar":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0;
case "cmdCancel":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdCancel)>0;
case "cmdClose":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0;
case "txtProviderContact":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProviderContact)>0;
case "txtProviderCompany":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProviderCompany)>0;
case "Label5":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label5)>0;
case "Label1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label1)>0;
case "Frame2":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame2)>0;
case "Label7":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label7)>0;
case "Label3":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label3)>0;
case "Label19":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label19)>0;
case "lblChangedBy":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lblChangedBy)>0;
case "Label4":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label4)>0;
case "lblChanged":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_lblChanged)>0;
case "Label12":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label12)>0;
case "Label11":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label11)>0;
case "Label10":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label10)>0;
case "Label9":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label9)>0;
case "Label8":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label8)>0;
case "Label6":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label6)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["txtReceivedBy"]=_Mobilize_References[3];
refs["cmdApprove"]=_Mobilize_References[4];
refs["txtStatus"]=_Mobilize_References[5];
refs["txtReceived"]=_Mobilize_References[6];
refs["txtChangedBy"]=_Mobilize_References[7];
refs["txtChanged"]=_Mobilize_References[8];
refs["txtOrderID"]=_Mobilize_References[9];
refs["txtNotes"]=_Mobilize_References[10];
refs["txtSubTotal"]=_Mobilize_References[11];
refs["txtTotal"]=_Mobilize_References[12];
refs["txtTotalTax"]=_Mobilize_References[13];
refs["txtFreightCharge"]=_Mobilize_References[14];
refs["txtSalesTax"]=_Mobilize_References[15];
refs["txtEntry"]=_Mobilize_References[16];
refs["fgDetails"]=_Mobilize_References[17];
refs["sbStatusBar_Panels_Panel1"]=_Mobilize_References[18];
refs["sbStatusBar"]=_Mobilize_References[19];
refs["cmdCancel"]=_Mobilize_References[20];
refs["cmdClose"]=_Mobilize_References[21];
refs["txtProviderContact"]=_Mobilize_References[22];
refs["txtProviderCompany"]=_Mobilize_References[23];
refs["Label5"]=_Mobilize_References[24];
refs["Label1"]=_Mobilize_References[25];
refs["Frame2"]=_Mobilize_References[26];
refs["Label7"]=_Mobilize_References[27];
refs["Label3"]=_Mobilize_References[28];
refs["Label19"]=_Mobilize_References[29];
refs["lblChangedBy"]=_Mobilize_References[30];
refs["Label4"]=_Mobilize_References[31];
refs["lblChanged"]=_Mobilize_References[32];
refs["Label12"]=_Mobilize_References[33];
refs["Label11"]=_Mobilize_References[34];
refs["Label10"]=_Mobilize_References[35];
refs["Label9"]=_Mobilize_References[36];
refs["Label8"]=_Mobilize_References[37];
refs["Label6"]=_Mobilize_References[38];
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
var ref_txtReceivedBy=(Mobilize.WebMap.Common.Core.IObservable)this.txtReceivedBy;if(ref_txtReceivedBy!=null)yield return ref_txtReceivedBy;
var ref_cmdApprove=(Mobilize.WebMap.Common.Core.IObservable)this.cmdApprove;if(ref_cmdApprove!=null)yield return ref_cmdApprove;
var ref_txtStatus=(Mobilize.WebMap.Common.Core.IObservable)this.txtStatus;if(ref_txtStatus!=null)yield return ref_txtStatus;
var ref_txtReceived=(Mobilize.WebMap.Common.Core.IObservable)this.txtReceived;if(ref_txtReceived!=null)yield return ref_txtReceived;
var ref_txtChangedBy=(Mobilize.WebMap.Common.Core.IObservable)this.txtChangedBy;if(ref_txtChangedBy!=null)yield return ref_txtChangedBy;
var ref_txtChanged=(Mobilize.WebMap.Common.Core.IObservable)this.txtChanged;if(ref_txtChanged!=null)yield return ref_txtChanged;
var ref_txtOrderID=(Mobilize.WebMap.Common.Core.IObservable)this.txtOrderID;if(ref_txtOrderID!=null)yield return ref_txtOrderID;
var ref_txtNotes=(Mobilize.WebMap.Common.Core.IObservable)this.txtNotes;if(ref_txtNotes!=null)yield return ref_txtNotes;
var ref_txtSubTotal=(Mobilize.WebMap.Common.Core.IObservable)this.txtSubTotal;if(ref_txtSubTotal!=null)yield return ref_txtSubTotal;
var ref_txtTotal=(Mobilize.WebMap.Common.Core.IObservable)this.txtTotal;if(ref_txtTotal!=null)yield return ref_txtTotal;
var ref_txtTotalTax=(Mobilize.WebMap.Common.Core.IObservable)this.txtTotalTax;if(ref_txtTotalTax!=null)yield return ref_txtTotalTax;
var ref_txtFreightCharge=(Mobilize.WebMap.Common.Core.IObservable)this.txtFreightCharge;if(ref_txtFreightCharge!=null)yield return ref_txtFreightCharge;
var ref_txtSalesTax=(Mobilize.WebMap.Common.Core.IObservable)this.txtSalesTax;if(ref_txtSalesTax!=null)yield return ref_txtSalesTax;
var ref_txtEntry=(Mobilize.WebMap.Common.Core.IObservable)this.txtEntry;if(ref_txtEntry!=null)yield return ref_txtEntry;
var ref_fgDetails=(Mobilize.WebMap.Common.Core.IObservable)this.fgDetails;if(ref_fgDetails!=null)yield return ref_fgDetails;
var ref_sbStatusBar_Panels_Panel1=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar_Panels_Panel1;if(ref_sbStatusBar_Panels_Panel1!=null)yield return ref_sbStatusBar_Panels_Panel1;
var ref_sbStatusBar=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar;if(ref_sbStatusBar!=null)yield return ref_sbStatusBar;
var ref_cmdCancel=(Mobilize.WebMap.Common.Core.IObservable)this.cmdCancel;if(ref_cmdCancel!=null)yield return ref_cmdCancel;
var ref_cmdClose=(Mobilize.WebMap.Common.Core.IObservable)this.cmdClose;if(ref_cmdClose!=null)yield return ref_cmdClose;
var ref_txtProviderContact=(Mobilize.WebMap.Common.Core.IObservable)this.txtProviderContact;if(ref_txtProviderContact!=null)yield return ref_txtProviderContact;
var ref_txtProviderCompany=(Mobilize.WebMap.Common.Core.IObservable)this.txtProviderCompany;if(ref_txtProviderCompany!=null)yield return ref_txtProviderCompany;
var ref_Label5=(Mobilize.WebMap.Common.Core.IObservable)this.Label5;if(ref_Label5!=null)yield return ref_Label5;
var ref_Label1=(Mobilize.WebMap.Common.Core.IObservable)this.Label1;if(ref_Label1!=null)yield return ref_Label1;
var ref_Frame2=(Mobilize.WebMap.Common.Core.IObservable)this.Frame2;if(ref_Frame2!=null)yield return ref_Frame2;
var ref_Label7=(Mobilize.WebMap.Common.Core.IObservable)this.Label7;if(ref_Label7!=null)yield return ref_Label7;
var ref_Label3=(Mobilize.WebMap.Common.Core.IObservable)this.Label3;if(ref_Label3!=null)yield return ref_Label3;
var ref_Label19=(Mobilize.WebMap.Common.Core.IObservable)this.Label19;if(ref_Label19!=null)yield return ref_Label19;
var ref_lblChangedBy=(Mobilize.WebMap.Common.Core.IObservable)this.lblChangedBy;if(ref_lblChangedBy!=null)yield return ref_lblChangedBy;
var ref_Label4=(Mobilize.WebMap.Common.Core.IObservable)this.Label4;if(ref_Label4!=null)yield return ref_Label4;
var ref_lblChanged=(Mobilize.WebMap.Common.Core.IObservable)this.lblChanged;if(ref_lblChanged!=null)yield return ref_lblChanged;
var ref_Label12=(Mobilize.WebMap.Common.Core.IObservable)this.Label12;if(ref_Label12!=null)yield return ref_Label12;
var ref_Label11=(Mobilize.WebMap.Common.Core.IObservable)this.Label11;if(ref_Label11!=null)yield return ref_Label11;
var ref_Label10=(Mobilize.WebMap.Common.Core.IObservable)this.Label10;if(ref_Label10!=null)yield return ref_Label10;
var ref_Label9=(Mobilize.WebMap.Common.Core.IObservable)this.Label9;if(ref_Label9!=null)yield return ref_Label9;
var ref_Label8=(Mobilize.WebMap.Common.Core.IObservable)this.Label8;if(ref_Label8!=null)yield return ref_Label8;
var ref_Label6=(Mobilize.WebMap.Common.Core.IObservable)this.Label6;if(ref_Label6!=null)yield return ref_Label6;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_DirtyFlag_1;
private uint _Mobilize_LoadedFlag_0;
private uint _Mobilize_LoadedFlag_1;
const uint _Mobilize_Dirty_currentSubTotal=(uint)1<<0;
const uint _Mobilize_Dirty_currentTotal=(uint)1<<1;
const uint _Mobilize_Dirty_currentTax=(uint)1<<2;
const uint _Mobilize_Dirty_currentFreightCharge=(uint)1<<3;
const uint _Mobilize_Dirty_currentTotalTax=(uint)1<<4;
const uint _Mobilize_Dirty_Action=(uint)1<<5;
const uint _Mobilize_Dirty_OrderId=(uint)1<<6;
const uint _Mobilize_Dirty_visualControls=(uint)1<<7;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<8;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<9;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_txtReceivedBy=(uint)1<<10;
const uint _Mobilize_Loaded_txtReceivedBy=(uint)1<<3;
const uint _Mobilize_Dirty_cmdApprove=(uint)1<<11;
const uint _Mobilize_Loaded_cmdApprove=(uint)1<<4;
const uint _Mobilize_Dirty_txtStatus=(uint)1<<12;
const uint _Mobilize_Loaded_txtStatus=(uint)1<<5;
const uint _Mobilize_Dirty_txtReceived=(uint)1<<13;
const uint _Mobilize_Loaded_txtReceived=(uint)1<<6;
const uint _Mobilize_Dirty_txtChangedBy=(uint)1<<14;
const uint _Mobilize_Loaded_txtChangedBy=(uint)1<<7;
const uint _Mobilize_Dirty_txtChanged=(uint)1<<15;
const uint _Mobilize_Loaded_txtChanged=(uint)1<<8;
const uint _Mobilize_Dirty_txtOrderID=(uint)1<<16;
const uint _Mobilize_Loaded_txtOrderID=(uint)1<<9;
const uint _Mobilize_Dirty_txtNotes=(uint)1<<17;
const uint _Mobilize_Loaded_txtNotes=(uint)1<<10;
const uint _Mobilize_Dirty_txtSubTotal=(uint)1<<18;
const uint _Mobilize_Loaded_txtSubTotal=(uint)1<<11;
const uint _Mobilize_Dirty_txtTotal=(uint)1<<19;
const uint _Mobilize_Loaded_txtTotal=(uint)1<<12;
const uint _Mobilize_Dirty_txtTotalTax=(uint)1<<20;
const uint _Mobilize_Loaded_txtTotalTax=(uint)1<<13;
const uint _Mobilize_Dirty_txtFreightCharge=(uint)1<<21;
const uint _Mobilize_Loaded_txtFreightCharge=(uint)1<<14;
const uint _Mobilize_Dirty_txtSalesTax=(uint)1<<22;
const uint _Mobilize_Loaded_txtSalesTax=(uint)1<<15;
const uint _Mobilize_Dirty_txtEntry=(uint)1<<23;
const uint _Mobilize_Loaded_txtEntry=(uint)1<<16;
const uint _Mobilize_Dirty_fgDetails=(uint)1<<24;
const uint _Mobilize_Loaded_fgDetails=(uint)1<<17;
const uint _Mobilize_Dirty_sbStatusBar_Panels_Panel1=(uint)1<<25;
const uint _Mobilize_Loaded_sbStatusBar_Panels_Panel1=(uint)1<<18;
const uint _Mobilize_Dirty_sbStatusBar=(uint)1<<26;
const uint _Mobilize_Loaded_sbStatusBar=(uint)1<<19;
const uint _Mobilize_Dirty_cmdCancel=(uint)1<<27;
const uint _Mobilize_Loaded_cmdCancel=(uint)1<<20;
const uint _Mobilize_Dirty_cmdClose=(uint)1<<28;
const uint _Mobilize_Loaded_cmdClose=(uint)1<<21;
const uint _Mobilize_Dirty_txtProviderContact=(uint)1<<29;
const uint _Mobilize_Loaded_txtProviderContact=(uint)1<<22;
const uint _Mobilize_Dirty_txtProviderCompany=(uint)1<<30;
const uint _Mobilize_Loaded_txtProviderCompany=(uint)1<<23;
const uint _Mobilize_Dirty_Label5=(uint)1<<31;
const uint _Mobilize_Loaded_Label5=(uint)1<<24;
const uint _Mobilize_Dirty_Label1=(uint)1<<32;
const uint _Mobilize_Loaded_Label1=(uint)1<<25;
const uint _Mobilize_Dirty_Frame2=(uint)1<<33;
const uint _Mobilize_Loaded_Frame2=(uint)1<<26;
const uint _Mobilize_Dirty_Label7=(uint)1<<34;
const uint _Mobilize_Loaded_Label7=(uint)1<<27;
const uint _Mobilize_Dirty_Label3=(uint)1<<35;
const uint _Mobilize_Loaded_Label3=(uint)1<<28;
const uint _Mobilize_Dirty_Label19=(uint)1<<36;
const uint _Mobilize_Loaded_Label19=(uint)1<<29;
const uint _Mobilize_Dirty_lblChangedBy=(uint)1<<37;
const uint _Mobilize_Loaded_lblChangedBy=(uint)1<<30;
const uint _Mobilize_Dirty_Label4=(uint)1<<38;
const uint _Mobilize_Loaded_Label4=(uint)1<<31;
const uint _Mobilize_Dirty_lblChanged=(uint)1<<39;
const uint _Mobilize_Loaded_lblChanged=(uint)1<<32;
const uint _Mobilize_Dirty_Label12=(uint)1<<40;
const uint _Mobilize_Loaded_Label12=(uint)1<<33;
const uint _Mobilize_Dirty_Label11=(uint)1<<41;
const uint _Mobilize_Loaded_Label11=(uint)1<<34;
const uint _Mobilize_Dirty_Label10=(uint)1<<42;
const uint _Mobilize_Loaded_Label10=(uint)1<<35;
const uint _Mobilize_Dirty_Label9=(uint)1<<43;
const uint _Mobilize_Loaded_Label9=(uint)1<<36;
const uint _Mobilize_Dirty_Label8=(uint)1<<44;
const uint _Mobilize_Loaded_Label8=(uint)1<<37;
const uint _Mobilize_Dirty_Label6=(uint)1<<45;
const uint _Mobilize_Loaded_Label6=(uint)1<<38;
private void Mobilize_Initialize_Properties()
{
#line 19
                                                   this.currentSubTotal=0;
#line hidden
 
#line 22
                                                this.currentTotal=0;
#line hidden
 
#line 25
                                              this.currentTax=0;
#line hidden
 
#line 28
                                                        this.currentFreightCharge=0;
#line hidden
 
#line 31
                                                   this.currentTotalTax=0;
#line hidden
 
#line 35
                                      this.Action=0;
#line hidden
 
#line 39
                                       this.OrderId=0;
#line hidden
 
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "txtReceivedBy", "cmdApprove", "txtStatus", "txtReceived", "txtChangedBy", "txtChanged", "txtOrderID", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgDetails", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label3", "Label19", "lblChangedBy", "Label4", "lblChanged", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6"};
#line hidden
 }
#line 14
    

#line hidden
                                                   
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentSubTotal_k__BackingField;
#line 19
                                                   

      [Intercepted]


      private double currentSubTotal 
#line 19
                                     { 
#line 19
                                       get                                          
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentSubTotal_k__BackingField;} 
#line 19

#line 19
                                            set                                               
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentSubTotal;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentSubTotal_k__BackingField=(double)value;} 
#line 19
                                                 } 
#line 20

#line hidden
                                                
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentTotal_k__BackingField;
#line 22
                                                

      [Intercepted]
      private double currentTotal 
#line 22
                                  { 
#line 22
                                    get                                       
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentTotal_k__BackingField;} 
#line 22

#line 22
                                         set                                            
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentTotal;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentTotal_k__BackingField=(double)value;} 
#line 22
                                              } 
#line 23

#line hidden
                                              
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentTax_k__BackingField;
#line 25
                                              

      [Intercepted]
      private double currentTax 
#line 25
                                { 
#line 25
                                  get                                     
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentTax_k__BackingField;} 
#line 25

#line 25
                                       set                                          
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentTax;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentTax_k__BackingField=(double)value;} 
#line 25
                                            } 
#line 26

#line hidden
                                                        
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentFreightCharge_k__BackingField;
#line 28
                                                        

      [Intercepted]
      private double currentFreightCharge 
#line 28
                                          { 
#line 28
                                            get                                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentFreightCharge_k__BackingField;} 
#line 28

#line 28
                                                 set                                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentFreightCharge;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentFreightCharge_k__BackingField=(double)value;} 
#line 28
                                                      } 
#line 29

#line hidden
                                                   
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private double currentTotalTax_k__BackingField;
#line 31
                                                   

      [Intercepted]
      private double currentTotalTax 
#line 31
                                     { 
#line 31
                                       get                                          
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.currentTotalTax_k__BackingField;} 
#line 31

#line 31
                                            set                                               
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_currentTotalTax;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.currentTotalTax_k__BackingField=(double)value;} 
#line 31
                                                 } 
#line 32

#line hidden
                                      
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Action_k__BackingField;
#line 35
                                      

      [Intercepted]

      public int Action 
#line 35
                        { 
#line 35
                          get                             
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Action_k__BackingField;} 
#line 35

#line 35
                               set                                  
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Action;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Action_k__BackingField=(int)value;} 
#line 35
                                    } 
#line 36

#line hidden
                                       
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int OrderId_k__BackingField;
#line 39
                                       

      [Intercepted]

      public int OrderId 
#line 39
                         { 
#line 39
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.OrderId_k__BackingField;} 
#line 39

#line 39
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_OrderId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.OrderId_k__BackingField=(int)value;} 
#line 39
                                     } 
#line 40


      public frmActionOrderReception()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 44
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



      private void cmdApprove_Click(Object eventSender, EventArgs eventArgs)
      {
      	try
      	{
      		if (txtStatus.Text.ToUpper() == "APPROVED")
            {
            	modMain.LogStatus("Order is already approved, not need to be approved again", this);
            	return;
            }

            if (txtStatus.Text.ToUpper() == "CANCELLED")
            {
            	modMain.LogStatus("Order was already approved by " + txtChangedBy.Text + " on " + txtChanged.Text + ", it cannot be approved", this);
            	return;
            }


            // UPDATE
            modConnection.ExecuteSql("Update OrderReceptions Set Status = 'APPROVED', ChangedBy = '" + modMain.UserId + "', ChangedDate = #" + DateTimeHelper.ToString(DateTime.Today) + "#" +
                                     " Where OrderId = " + OrderId.ToString());

            modConnection.ExecuteSql("Select ProductId, Quantity, UnitPrice, LineTotal " +
                                     "From OrderReceptionDetails Where OrderID = " + OrderId.ToString());


            int newId = 0;
            while (!modConnection.rs.EOF)
            {

            	modConnection.ExecuteSql2("Insert Into Stocks " +
            	                          "(ProductID, Stock, InitialStock, DateStarted, DateModified, User, UnitPrice, StockPrice) Values " +
            	                          "('" + Convert.ToString(modConnection.rs["ProductId"]) + "'," + Convert.ToString(modConnection.rs["Quantity"]) + "," + Convert.ToString(modConnection.rs["Quantity"]) + ", #" + DateTimeHelper.ToString(DateTime.Today) + "#, #" + DateTimeHelper.ToString(DateTime.Today) + "#, '" + modMain.UserId + "', " + Convert.ToString(modConnection.rs["UnitPrice"]) + "," + Convert.ToString(modConnection.rs["LineTotal"]) + ")");

            	modConnection.ExecuteSql2("Select Max(StockID) as NewId From Stocks");
            	newId = Convert.ToInt32(modConnection.rs2["NewId"]);

            	modConnection.ExecuteSql2("Insert Into StockLogs " +
            	                          "(DocID, DocType, StockID, ProductId, Quantity, StockPrice, Date, User) Values " +
            	                          "(" + Convert.ToString(modConnection.rs["ProductId"]) + "," + Convert.ToString(modConnection.rs["ProductId"]) + "," + "," + Convert.ToString(modConnection.rs["ProductId"]) + "," + "," + Convert.ToString(modConnection.rs["ProductId"]) + "," + "," + Convert.ToString(modConnection.rs["ProductId"]) + "," + "," + Convert.ToString(modConnection.rs["ProductId"]) + ",#" + DateTimeHelper.ToString(DateTime.Today) + "#, '" + modMain.UserId + "')");

            	modConnection.rs.MoveNext();
            }


            modConnection.ExecuteSql("Insert Into Stocks " +
                                     "(ProductID, Stock, InitialStock, DateStarted, DateModified, User, UnitPrice, StockPrice) " +
                                     "Select ProductId, Quantity, Quantity, #" + DateTimeHelper.ToString(DateTime.Today) + "#, #" + DateTimeHelper.ToString(DateTime.Today) + "#, '" + modMain.UserId + "', UnitPrice, LineTotal " +
                                     "From OrderReceptionDetails " +
                                     "Where OrderID = " + OrderId.ToString());

            modConnection.ExecuteSql("Update Products as p Set UnitsInStock = UnitsInStock + " +
                                     " ( Select Sum(Quantity) From OrderReceptionDetails Where OrderId = " + OrderId.ToString() + " and ProductId = p.ProductId) " +
                                     " Where ProductId in Select ProductId From OrderReceptionDetails Where OrderId = " + OrderId.ToString());
         }
         catch (System.Exception excep)
         {
            Mobilize.Web.MessageBox.Show("An error has occurred adding the data. Error: (" + Stub._Microsoft.VisualBasic.Information.Err().Number.ToString() + ") " + excep.Message, "Error", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
         }

      }

      private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
      {
      	try
      	{
      		if (txtStatus.Text.ToUpper() == "CANCELLED")
            {
            	modMain.LogStatus("Order was already cancelled, not need to be cancelled again", this);
            	return;
            }
            if (txtStatus.Text.ToUpper() == "APPROVED")
            {
            	modMain.LogStatus("Order was already cancelled by " + txtChangedBy.Text + " on " + txtChanged.Text + ", it cannot be canceled", this);
            	return;
            }


            if ( Mobilize.Web.MessageBox.Show("Do you want to cancel the order reception?", "Confirm cancellation", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) != Mobilize.Web.DialogResult.Yes)
            {
            	return;
            }

            // UPDATE
            modConnection.ExecuteSql("Update OrderReceptions Set Status = 'CANCELLED', ChangedBy = '" + modMain.UserId + "', ChangedDate = #" + DateTimeHelper.ToString(DateTime.Today) + "#" +
                                     " Where OrderId = " + OrderId.ToString());

            LoadData();
            Mobilize.Web.MessageBox.Show("The order was successfully cancelled", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName);
            this.Close();
         }
         catch (System.Exception excep)
         {
            Mobilize.Web.MessageBox.Show("An error has occurred adding the data. Error: (" + Stub._Microsoft.VisualBasic.Information.Err().Number.ToString() + ") " + excep.Message, "Error", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
         }

      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080

      private void Form_Load()
      {
      	//LoadData
      	if (Action != 0)
         {

         	switch((Action))
         	{
         		case 1 :
         			cmdApprove_Click(cmdApprove, new EventArgs());
         			break;
         		case 2 :
         			cmdCancel_Click(cmdCancel, new EventArgs());
         			break;
         	}
         }
      }

      public void LoadData()
      {
      	currentSubTotal = 0;
      	currentTotalTax = 0;
      	modConnection.ExecuteSql("Select o.OrderDate, u.Fullname, o.Status, p.ProviderName, p.ContactFirstName + ' ' + p.ContactLastName as Contact, o.ChangedDate, o.ChangedBy, o.FreightCharge, o.SalesTaxRate, o.Notes " +
      	                         "From OrderReceptions as o, Users as u, Providers as p " +
      	                         "Where o.OrderID = " + OrderId.ToString() + " And u.Username = o.ReceivedBy And p.ProviderId = o.ProviderId");
      	if (modConnection.rs.EOF)
      	{
      		modMain.LogStatus("The order with the ID '" + OrderId.ToString() + "' does not exist", this);
      		return;
      	}
      	txtOrderID.Text = OrderId.ToString();
      	txtReceived.Text = Convert.ToString(modConnection.rs["OrderDate"]);
      	txtReceivedBy.Text = Convert.ToString(modConnection.rs["Fullname"]);
      	//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
      	if (System.DBNull.Value.Equals(modConnection.rs["Notes"]))
      	{
      		txtNotes.Text = Convert.ToString(modConnection.rs["Notes"]);
      	}
      	txtFreightCharge.Text = Convert.ToString(modConnection.rs["FreightCharge"]);
      	currentFreightCharge = Convert.ToDouble(modConnection.rs["FreightCharge"]);
      	txtSalesTax.Text = Convert.ToString(modConnection.rs["SalesTaxRate"]);
      	currentTax = Convert.ToDouble(modConnection.rs["SalesTaxRate"]);
      	txtProviderCompany.Text = Convert.ToString(modConnection.rs["ProviderName"]);
      	txtProviderContact.Text = Convert.ToString(modConnection.rs["Contact"]);
      	txtStatus.Text = Convert.ToString(modConnection.rs["Status"]);
      	//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
      	if (System.DBNull.Value.Equals(modConnection.rs["ChangedDate"]))
      	{
      		txtChanged.Text = Convert.ToString(modConnection.rs["ChangedDate"]);
      	}
      	//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1049
      	if (System.DBNull.Value.Equals(modConnection.rs["ChangedBy"]))
      	{
      		txtChangedBy.Text = Convert.ToString(modConnection.rs["ChangedBy"]);
      	}

      	bool isReceived = txtStatus.Text == "RECEIVED";
         lblChanged.Visible = !isReceived;
         lblChangedBy.Visible = !isReceived;
         txtChanged.Visible = !isReceived;
         txtChangedBy.Visible = !isReceived;
         cmdApprove.Enabled = true; // Received
         cmdCancel.Enabled = true; // Received

         if (txtStatus.Text == "APPROVED")
         {
         	lblChanged.Text = "Approved Date:";
         	lblChangedBy.Text = "Approved By:";
         }
         else
         {
         	lblChanged.Text = "Cancelled Date:";
         	lblChangedBy.Text = "Cancelled By:";
         }
         LoadDetails();
         DisplayTotals();
      }

      private void DisplayTotals()
      {
      	currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax;
      	txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00");
      	txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00");
      	txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00");
      }


      private void AddToTotals(double current)
      {
      	currentSubTotal += current;
      	currentTotalTax = currentSubTotal * currentTax;
      	currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax;
      	txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00");
      	txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00");
      	txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00");
      }


      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
      	this.Close();
      }

      private void LoadDetails()
      {

      	modConnection.ExecuteSql("Select d.Quantity, p.ProductID, p.ProductName, d.UnitPrice, d.SalePrice, p.UnitsInStock, p.UnitsOnOrder, Str(p.QuantityPerUnit) + p.Unit, d.LineTotal From Products as p, OrderReceptionDetails as d " +
      	                         "Where d.OrderID = " + OrderId.ToString() + " And d.ProductId = p.ProductId");

      	int i = 0;
      	fgDetails.RowsCount = 0;
      	fgDetails.ColumnsCount = 9;
      	fgDetails.FixedColumns = 0;
      	fgDetails.AddItem("Quantity" + "\t" + "Code" + "\t" + "Product" + "\t" + "UnitPrice" + "\t" + "Price" + "\t" + "Existence" + "\t" + "Ordered" + "\t" + "Quantity per unit" + "\t" + "Line Total");
      	fgDetails.RowsCount = modConnection.rs.RecordCount + 1;
      	if (fgDetails.RowsCount == 1)
         {
         	fgDetails.FixedRows = 0;
         }
         else
         {
         	fgDetails.FixedRows = 1;
         }
         i = 1;
         while (!modConnection.rs.EOF)
         {
         	int tempForEndVar = modConnection.rs.FieldsMetadata.Count;
         	for (int j = 1; j <= tempForEndVar; j++)
         	{
         		//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         		if (modConnection.rs.GetField(i) != null)
               {
               	fgDetails[i, j - 1].Value = Convert.ToString(modConnection.rs[j - 1]);
               }
            }
            AddToTotals(Convert.ToDouble(modConnection.rs["LineTotal"]));
            modConnection.rs.MoveNext();
            i++;
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
private SKS.frmActionOrderReception m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmActionOrderReception>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmActionOrderReception>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmActionOrderReception)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmActionOrderReception)value;}}
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
