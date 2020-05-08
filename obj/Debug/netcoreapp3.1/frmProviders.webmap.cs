#pragma warning disable
#line 1 "frmProviders.cs"
#pragma warning disable
#line 1 "frmProviders.cs"
using System;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;

namespace SKS
{

   [Observable]
   internal partial class frmProviders
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[43];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_NewMode)>0)
{yield return "NewMode";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_EditMode)>0)
{yield return "EditMode";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CancellingMode)>0)
{yield return "CancellingMode";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CurrentProviderID)>0)
{yield return "CurrentProviderID";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_dcProviders)>0)
{yield return "dcProviders";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_1)>0)
{yield return "_txtField_1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_4)>0)
{yield return "_txtField_4";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_0)>0)
{yield return "_txtField_0";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_6)>0)
{yield return "_txtField_6";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_7)>0)
{yield return "_txtField_7";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_2)>0)
{yield return "_txtField_2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_5)>0)
{yield return "_txtField_5";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_11)>0)
{yield return "_txtField_11";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_13)>0)
{yield return "_txtField_13";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_12)>0)
{yield return "_txtField_12";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label7)>0)
{yield return "Label7";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label3)>0)
{yield return "Label3";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label2)>0)
{yield return "Label2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame2)>0)
{yield return "Frame2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_8)>0)
{yield return "_txtField_8";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_10)>0)
{yield return "_txtField_10";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_14)>0)
{yield return "_txtField_14";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_9)>0)
{yield return "_txtField_9";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0)
{yield return "Label4";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label15)>0)
{yield return "Label15";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label14)>0)
{yield return "Label14";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label13)>0)
{yield return "Label13";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label12)>0)
{yield return "Label12";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label11)>0)
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
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label1)>0)
{yield return "Label1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame1)>0)
{yield return "Frame1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_ImageList1)>0)
{yield return "ImageList1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button1)>0)
{yield return "Toolbar1_Buttons_Button1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button2)>0)
{yield return "Toolbar1_Buttons_Button2";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button3)>0)
{yield return "Toolbar1_Buttons_Button3";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button4)>0)
{yield return "Toolbar1_Buttons_Button4";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button5)>0)
{yield return "Toolbar1_Buttons_Button5";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button6)>0)
{yield return "Toolbar1_Buttons_Button6";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1)>0)
{yield return "Toolbar1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtField)>0)
{yield return "txtField";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "NewMode":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_NewMode)>0;
case "EditMode":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_EditMode)>0;
case "CancellingMode":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CancellingMode)>0;
case "CurrentProviderID":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CurrentProviderID)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "dcProviders":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_dcProviders)>0;
case "_txtField_1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_1)>0;
case "_txtField_4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_4)>0;
case "_txtField_0":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_0)>0;
case "_txtField_6":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_6)>0;
case "_txtField_7":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_7)>0;
case "_txtField_2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_2)>0;
case "_txtField_5":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_5)>0;
case "_txtField_11":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_11)>0;
case "_txtField_13":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_13)>0;
case "_txtField_12":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_12)>0;
case "Label7":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label7)>0;
case "Label3":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label3)>0;
case "Label2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label2)>0;
case "Frame2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame2)>0;
case "_txtField_8":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_8)>0;
case "_txtField_10":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_10)>0;
case "_txtField_14":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_14)>0;
case "_txtField_9":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_9)>0;
case "Label4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0;
case "Label15":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label15)>0;
case "Label14":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label14)>0;
case "Label13":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label13)>0;
case "Label12":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label12)>0;
case "Label11":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label11)>0;
case "Label10":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label10)>0;
case "Label9":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label9)>0;
case "Label8":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label8)>0;
case "Label6":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label6)>0;
case "Label1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Label1)>0;
case "Frame1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Frame1)>0;
case "ImageList1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_ImageList1)>0;
case "Toolbar1_Buttons_Button1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button1)>0;
case "Toolbar1_Buttons_Button2":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button2)>0;
case "Toolbar1_Buttons_Button3":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button3)>0;
case "Toolbar1_Buttons_Button4":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button4)>0;
case "Toolbar1_Buttons_Button5":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button5)>0;
case "Toolbar1_Buttons_Button6":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button6)>0;
case "Toolbar1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1)>0;
case "txtField":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtField)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["dcProviders"]=_Mobilize_References[3];
refs["_txtField_1"]=_Mobilize_References[4];
refs["_txtField_4"]=_Mobilize_References[5];
refs["_txtField_0"]=_Mobilize_References[6];
refs["_txtField_6"]=_Mobilize_References[7];
refs["_txtField_7"]=_Mobilize_References[8];
refs["_txtField_2"]=_Mobilize_References[9];
refs["_txtField_5"]=_Mobilize_References[10];
refs["_txtField_11"]=_Mobilize_References[11];
refs["_txtField_13"]=_Mobilize_References[12];
refs["_txtField_12"]=_Mobilize_References[13];
refs["Label7"]=_Mobilize_References[14];
refs["Label3"]=_Mobilize_References[15];
refs["Label2"]=_Mobilize_References[16];
refs["Frame2"]=_Mobilize_References[17];
refs["_txtField_8"]=_Mobilize_References[18];
refs["_txtField_10"]=_Mobilize_References[19];
refs["_txtField_14"]=_Mobilize_References[20];
refs["_txtField_9"]=_Mobilize_References[21];
refs["Label4"]=_Mobilize_References[22];
refs["Label15"]=_Mobilize_References[23];
refs["Label14"]=_Mobilize_References[24];
refs["Label13"]=_Mobilize_References[25];
refs["Label12"]=_Mobilize_References[26];
refs["Label11"]=_Mobilize_References[27];
refs["Label10"]=_Mobilize_References[28];
refs["Label9"]=_Mobilize_References[29];
refs["Label8"]=_Mobilize_References[30];
refs["Label6"]=_Mobilize_References[31];
refs["Label1"]=_Mobilize_References[32];
refs["Frame1"]=_Mobilize_References[33];
refs["ImageList1"]=_Mobilize_References[34];
refs["Toolbar1_Buttons_Button1"]=_Mobilize_References[35];
refs["Toolbar1_Buttons_Button2"]=_Mobilize_References[36];
refs["Toolbar1_Buttons_Button3"]=_Mobilize_References[37];
refs["Toolbar1_Buttons_Button4"]=_Mobilize_References[38];
refs["Toolbar1_Buttons_Button5"]=_Mobilize_References[39];
refs["Toolbar1_Buttons_Button6"]=_Mobilize_References[40];
refs["Toolbar1"]=_Mobilize_References[41];
refs["txtField"]=_Mobilize_References[42];
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
var ref_dcProviders=(Mobilize.WebMap.Common.Core.IObservable)this.dcProviders;if(ref_dcProviders!=null)yield return ref_dcProviders;
var ref__txtField_1=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_1;if(ref__txtField_1!=null)yield return ref__txtField_1;
var ref__txtField_4=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_4;if(ref__txtField_4!=null)yield return ref__txtField_4;
var ref__txtField_0=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_0;if(ref__txtField_0!=null)yield return ref__txtField_0;
var ref__txtField_6=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_6;if(ref__txtField_6!=null)yield return ref__txtField_6;
var ref__txtField_7=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_7;if(ref__txtField_7!=null)yield return ref__txtField_7;
var ref__txtField_2=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_2;if(ref__txtField_2!=null)yield return ref__txtField_2;
var ref__txtField_5=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_5;if(ref__txtField_5!=null)yield return ref__txtField_5;
var ref__txtField_11=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_11;if(ref__txtField_11!=null)yield return ref__txtField_11;
var ref__txtField_13=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_13;if(ref__txtField_13!=null)yield return ref__txtField_13;
var ref__txtField_12=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_12;if(ref__txtField_12!=null)yield return ref__txtField_12;
var ref_Label7=(Mobilize.WebMap.Common.Core.IObservable)this.Label7;if(ref_Label7!=null)yield return ref_Label7;
var ref_Label3=(Mobilize.WebMap.Common.Core.IObservable)this.Label3;if(ref_Label3!=null)yield return ref_Label3;
var ref_Label2=(Mobilize.WebMap.Common.Core.IObservable)this.Label2;if(ref_Label2!=null)yield return ref_Label2;
var ref_Frame2=(Mobilize.WebMap.Common.Core.IObservable)this.Frame2;if(ref_Frame2!=null)yield return ref_Frame2;
var ref__txtField_8=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_8;if(ref__txtField_8!=null)yield return ref__txtField_8;
var ref__txtField_10=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_10;if(ref__txtField_10!=null)yield return ref__txtField_10;
var ref__txtField_14=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_14;if(ref__txtField_14!=null)yield return ref__txtField_14;
var ref__txtField_9=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_9;if(ref__txtField_9!=null)yield return ref__txtField_9;
var ref_Label4=(Mobilize.WebMap.Common.Core.IObservable)this.Label4;if(ref_Label4!=null)yield return ref_Label4;
var ref_Label15=(Mobilize.WebMap.Common.Core.IObservable)this.Label15;if(ref_Label15!=null)yield return ref_Label15;
var ref_Label14=(Mobilize.WebMap.Common.Core.IObservable)this.Label14;if(ref_Label14!=null)yield return ref_Label14;
var ref_Label13=(Mobilize.WebMap.Common.Core.IObservable)this.Label13;if(ref_Label13!=null)yield return ref_Label13;
var ref_Label12=(Mobilize.WebMap.Common.Core.IObservable)this.Label12;if(ref_Label12!=null)yield return ref_Label12;
var ref_Label11=(Mobilize.WebMap.Common.Core.IObservable)this.Label11;if(ref_Label11!=null)yield return ref_Label11;
var ref_Label10=(Mobilize.WebMap.Common.Core.IObservable)this.Label10;if(ref_Label10!=null)yield return ref_Label10;
var ref_Label9=(Mobilize.WebMap.Common.Core.IObservable)this.Label9;if(ref_Label9!=null)yield return ref_Label9;
var ref_Label8=(Mobilize.WebMap.Common.Core.IObservable)this.Label8;if(ref_Label8!=null)yield return ref_Label8;
var ref_Label6=(Mobilize.WebMap.Common.Core.IObservable)this.Label6;if(ref_Label6!=null)yield return ref_Label6;
var ref_Label1=(Mobilize.WebMap.Common.Core.IObservable)this.Label1;if(ref_Label1!=null)yield return ref_Label1;
var ref_Frame1=(Mobilize.WebMap.Common.Core.IObservable)this.Frame1;if(ref_Frame1!=null)yield return ref_Frame1;
var ref_ImageList1=(Mobilize.WebMap.Common.Core.IObservable)this.ImageList1;if(ref_ImageList1!=null)yield return ref_ImageList1;
var ref_Toolbar1_Buttons_Button1=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button1;if(ref_Toolbar1_Buttons_Button1!=null)yield return ref_Toolbar1_Buttons_Button1;
var ref_Toolbar1_Buttons_Button2=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button2;if(ref_Toolbar1_Buttons_Button2!=null)yield return ref_Toolbar1_Buttons_Button2;
var ref_Toolbar1_Buttons_Button3=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button3;if(ref_Toolbar1_Buttons_Button3!=null)yield return ref_Toolbar1_Buttons_Button3;
var ref_Toolbar1_Buttons_Button4=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button4;if(ref_Toolbar1_Buttons_Button4!=null)yield return ref_Toolbar1_Buttons_Button4;
var ref_Toolbar1_Buttons_Button5=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button5;if(ref_Toolbar1_Buttons_Button5!=null)yield return ref_Toolbar1_Buttons_Button5;
var ref_Toolbar1_Buttons_Button6=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button6;if(ref_Toolbar1_Buttons_Button6!=null)yield return ref_Toolbar1_Buttons_Button6;
var ref_Toolbar1=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1;if(ref_Toolbar1!=null)yield return ref_Toolbar1;
var ref_txtField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.txtField);if(ref_txtField!=null)yield return ref_txtField;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_DirtyFlag_1;
private uint _Mobilize_LoadedFlag_0;
private uint _Mobilize_LoadedFlag_1;
const uint _Mobilize_Dirty_NewMode=(uint)1<<0;
const uint _Mobilize_Dirty_EditMode=(uint)1<<1;
const uint _Mobilize_Dirty_CancellingMode=(uint)1<<2;
const uint _Mobilize_Dirty_CurrentProviderID=(uint)1<<3;
const uint _Mobilize_Dirty_visualControls=(uint)1<<4;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<5;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<6;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_dcProviders=(uint)1<<7;
const uint _Mobilize_Loaded_dcProviders=(uint)1<<3;
const uint _Mobilize_Dirty__txtField_1=(uint)1<<8;
const uint _Mobilize_Loaded__txtField_1=(uint)1<<4;
const uint _Mobilize_Dirty__txtField_4=(uint)1<<9;
const uint _Mobilize_Loaded__txtField_4=(uint)1<<5;
const uint _Mobilize_Dirty__txtField_0=(uint)1<<10;
const uint _Mobilize_Loaded__txtField_0=(uint)1<<6;
const uint _Mobilize_Dirty__txtField_6=(uint)1<<11;
const uint _Mobilize_Loaded__txtField_6=(uint)1<<7;
const uint _Mobilize_Dirty__txtField_7=(uint)1<<12;
const uint _Mobilize_Loaded__txtField_7=(uint)1<<8;
const uint _Mobilize_Dirty__txtField_2=(uint)1<<13;
const uint _Mobilize_Loaded__txtField_2=(uint)1<<9;
const uint _Mobilize_Dirty__txtField_5=(uint)1<<14;
const uint _Mobilize_Loaded__txtField_5=(uint)1<<10;
const uint _Mobilize_Dirty__txtField_11=(uint)1<<15;
const uint _Mobilize_Loaded__txtField_11=(uint)1<<11;
const uint _Mobilize_Dirty__txtField_13=(uint)1<<16;
const uint _Mobilize_Loaded__txtField_13=(uint)1<<12;
const uint _Mobilize_Dirty__txtField_12=(uint)1<<17;
const uint _Mobilize_Loaded__txtField_12=(uint)1<<13;
const uint _Mobilize_Dirty_Label7=(uint)1<<18;
const uint _Mobilize_Loaded_Label7=(uint)1<<14;
const uint _Mobilize_Dirty_Label3=(uint)1<<19;
const uint _Mobilize_Loaded_Label3=(uint)1<<15;
const uint _Mobilize_Dirty_Label2=(uint)1<<20;
const uint _Mobilize_Loaded_Label2=(uint)1<<16;
const uint _Mobilize_Dirty_Frame2=(uint)1<<21;
const uint _Mobilize_Loaded_Frame2=(uint)1<<17;
const uint _Mobilize_Dirty__txtField_8=(uint)1<<22;
const uint _Mobilize_Loaded__txtField_8=(uint)1<<18;
const uint _Mobilize_Dirty__txtField_10=(uint)1<<23;
const uint _Mobilize_Loaded__txtField_10=(uint)1<<19;
const uint _Mobilize_Dirty__txtField_14=(uint)1<<24;
const uint _Mobilize_Loaded__txtField_14=(uint)1<<20;
const uint _Mobilize_Dirty__txtField_9=(uint)1<<25;
const uint _Mobilize_Loaded__txtField_9=(uint)1<<21;
const uint _Mobilize_Dirty_Label4=(uint)1<<26;
const uint _Mobilize_Loaded_Label4=(uint)1<<22;
const uint _Mobilize_Dirty_Label15=(uint)1<<27;
const uint _Mobilize_Loaded_Label15=(uint)1<<23;
const uint _Mobilize_Dirty_Label14=(uint)1<<28;
const uint _Mobilize_Loaded_Label14=(uint)1<<24;
const uint _Mobilize_Dirty_Label13=(uint)1<<29;
const uint _Mobilize_Loaded_Label13=(uint)1<<25;
const uint _Mobilize_Dirty_Label12=(uint)1<<30;
const uint _Mobilize_Loaded_Label12=(uint)1<<26;
const uint _Mobilize_Dirty_Label11=(uint)1<<31;
const uint _Mobilize_Loaded_Label11=(uint)1<<27;
const uint _Mobilize_Dirty_Label10=(uint)1<<32;
const uint _Mobilize_Loaded_Label10=(uint)1<<28;
const uint _Mobilize_Dirty_Label9=(uint)1<<33;
const uint _Mobilize_Loaded_Label9=(uint)1<<29;
const uint _Mobilize_Dirty_Label8=(uint)1<<34;
const uint _Mobilize_Loaded_Label8=(uint)1<<30;
const uint _Mobilize_Dirty_Label6=(uint)1<<35;
const uint _Mobilize_Loaded_Label6=(uint)1<<31;
const uint _Mobilize_Dirty_Label1=(uint)1<<36;
const uint _Mobilize_Loaded_Label1=(uint)1<<32;
const uint _Mobilize_Dirty_Frame1=(uint)1<<37;
const uint _Mobilize_Loaded_Frame1=(uint)1<<33;
const uint _Mobilize_Dirty_ImageList1=(uint)1<<38;
const uint _Mobilize_Loaded_ImageList1=(uint)1<<34;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button1=(uint)1<<39;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button1=(uint)1<<35;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button2=(uint)1<<40;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button2=(uint)1<<36;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button3=(uint)1<<41;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button3=(uint)1<<37;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button4=(uint)1<<42;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button4=(uint)1<<38;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button5=(uint)1<<43;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button5=(uint)1<<39;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button6=(uint)1<<44;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button6=(uint)1<<40;
const uint _Mobilize_Dirty_Toolbar1=(uint)1<<45;
const uint _Mobilize_Loaded_Toolbar1=(uint)1<<41;
const uint _Mobilize_Dirty_txtField=(uint)1<<46;
const uint _Mobilize_Loaded_txtField=(uint)1<<42;
private void Mobilize_Initialize_Properties()
{
#line 15
                                         this.NewMode=false;
#line hidden
 
#line 18
                                          this.EditMode=false;
#line hidden
 
#line 21
                                                this.CancellingMode=false;
#line hidden
 
#line 24
                                                 this.CurrentProviderID=0;
#line hidden
 
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "dcProviders", "_txtField_1", "_txtField_4", "_txtField_0", "_txtField_6", "_txtField_7", "_txtField_2", "_txtField_5", "_txtField_11", "_txtField_13", "_txtField_12", "Label7", "Label3", "Label2", "Frame2", "_txtField_8", "_txtField_10", "_txtField_14", "_txtField_9", "Label4", "Label15", "Label14", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "Label1", "Frame1", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField"};
#line hidden
 
#line 176
                                                           this.txtField=new Mobilize.Web.TextBox[15];
#line hidden
 }
#line 11
    

#line hidden
                                         
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool NewMode_k__BackingField;
#line 15
                                         

      [Intercepted]

      private bool NewMode 
#line 15
                           { 
#line 15
                             get                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.NewMode_k__BackingField;} 
#line 15

#line 15
                                  set                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_NewMode;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.NewMode_k__BackingField=(bool)value;} 
#line 15
                                       } 
#line 16

#line hidden
                                          
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool EditMode_k__BackingField;
#line 18
                                          

      [Intercepted]
      private bool EditMode 
#line 18
                            { 
#line 18
                              get                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.EditMode_k__BackingField;} 
#line 18

#line 18
                                   set                                      
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_EditMode;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.EditMode_k__BackingField=(bool)value;} 
#line 18
                                        } 
#line 19

#line hidden
                                                
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool CancellingMode_k__BackingField;
#line 21
                                                

      [Intercepted]
      private bool CancellingMode 
#line 21
                                  { 
#line 21
                                    get                                       
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.CancellingMode_k__BackingField;} 
#line 21

#line 21
                                         set                                            
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CancellingMode;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CancellingMode_k__BackingField=(bool)value;} 
#line 21
                                              } 
#line 22

#line hidden
                                                 
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int CurrentProviderID_k__BackingField;
#line 24
                                                 

      [Intercepted]
      public int CurrentProviderID 
#line 24
                                   { 
#line 24
                                     get                                        
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.CurrentProviderID_k__BackingField;} 
#line 24

#line 24
                                          set                                             
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CurrentProviderID;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CurrentProviderID_k__BackingField=(int)value;} 
#line 24
                                               } 
#line 25

      //Private Sub adcProviders_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
      //NewMode = False
      //EditMode = False
      //CancellingMode = False
      //End Sub

      //Private Sub dcProviders_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
      //CancellingMode = True
      //End Sub


      public frmProviders()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 39
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


      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080

      private void Form_Load()
      {
      	dcProviders.ConnectionString = modMain.ConnectionString;

      	NewMode = false;
      	EditMode = false;
      	CancellingMode = false;
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      	CurrentProviderID = Convert.ToInt32(dcProviders.Recordset["ProviderId"]);
      }

      private void Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
      {
         Mobilize.Web.ToolStripItem Button = (Mobilize.Web.ToolStripItem) eventSender;
         object x = null;
         //SKS Demo TODO: dcProviders.SetFocus()
         switch(Button.Text)
         {
         	case "Add" :
         		//Add new record 
         		NewMode = true;
         		dcProviders.Recordset.AddNew();
         		break;
         	case "Edit" :
         		//Edit mode 
         		EditMode = true;
         		break;
         	case "Save" :
         		Save();
         		break;
         	case "Delete" :
         		//Delete record 
         		if ( Mobilize.Web.MessageBox.Show("Are you sure you want to delete this record?", "Delete record", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) == Mobilize.Web.DialogResult.Yes)
               {
               	dcProviders.Recordset.Delete();
               	dcProviders.Recordset.Requery();
               }
               break;
            case "Search" :
               //Search for records 
               modFunctions.SearchShow("Providers", "ProviderName", "Provider");
               break;
            case "Cancel" :
               CancellingMode = true;
               //Cancel edited changes 
               EditMode = false;
               NewMode = false;
               dcProviders.Recordset.CancelUpdate();
               dcProviders.Recordset.Requery();
               CancellingMode = false;
               this.Close();
               break;
         }
      }


      private void Save()
      {
      	//Save data
      	if (modFunctions.TextBoxEmpty(txtField[0]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[1]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[2]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[4]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[5]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[6]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[7]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[7]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[10]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[11]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[12]))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtField[14]))
      	{
      		return;
      	}
      	dcProviders.Recordset.Update();
      	dcProviders.Recordset.Requery();
      	EditMode = false;
      	NewMode = false;
      }

      private void txtField_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	if (!CancellingMode)
      	{
      		EditMode = true;
      	}
      }
public class _Mobilize_SharedState :Mobilize.WebMap.Common.Core.IObservable,Mobilize.WebMap.Common.Core.IDelta{
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[1];
Mobilize.WebMap.Common.Core.Identifier Mobilize.WebMap.Common.Core.IObservable.MobilizeId{get ;set ;}=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.IdentifierService.GetIdentifier();
Mobilize.WebMap.Common.Core.ReferenceMap Mobilize.WebMap.Common.Core.IObservable.References{
get=>this._Mobilize_GetReferenceMap(new Mobilize.WebMap.Common.Core.ReferenceMap());
set=>throw new System.NotImplementedException();}

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
bool Mobilize.WebMap.Common.Core.ITrackable.HasChanged{get=>(this._Mobilize_ControlFlag&_Mobilize_HasChanged_Flag)>0;}
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
}Mobilize.WebMap.Common.Core.IObservable Mobilize.WebMap.Common.Core.IDelta.Target{get =>this;
set =>throw new System.NotImplementedException();
}System.Collections.Generic.IEnumerable<string> Mobilize.WebMap.Common.Core.IDelta.Changes=>this._Mobilize_GetChanges();
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
private SKS.frmProviders m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmProviders>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmProviders>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmProviders)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmProviders)value;}}
#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool m_InitializingDefInstance_k__BackingField;
internal bool m_InitializingDefInstance {get
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.m_InitializingDefInstance_k__BackingField;}set
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_InitializingDefInstance;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_InitializingDefInstance_k__BackingField=(bool)value;}}}
   	//Used in search form
   	//Public Sub SearchCriteria(field As String, value As String)
   	//ExecuteSql "Select * from Providers where " & field & " LIKE '" & value & "%'"
   	//If rs.RecordCount = 0 Then
   	//    MsgBox "There are no records with the selected criteria", vbInformation, "Search"
   	//Else
   	//    LogStatus "There are " & rs.RecordCount & " that meet with the selected criteria"
   	//    Set dcProviders.Recordset = rs
   	//End If
   	//End Sub

   }
}
#pragma warning restore
