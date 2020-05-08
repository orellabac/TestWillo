#pragma warning disable
#line 1 "frmMain.cs"
#pragma warning disable
#line 1 "frmMain.cs"
using System;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmMain
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[26];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0)
{yield return "visualControls";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0)
{yield return "components";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0)
{yield return "ToolTipMain";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuCustomer)>0)
{yield return "mnuCustomer";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuProviders)>0)
{yield return "mnuProviders";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuExit)>0)
{yield return "mnuExit";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuFile)>0)
{yield return "mnuFile";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuCreateOrderRequest)>0)
{yield return "mnuCreateOrderRequest";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuOrderRequestsApproval)>0)
{yield return "mnuOrderRequestsApproval";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lExit2)>0)
{yield return "lExit2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuCreateOrderReception)>0)
{yield return "mnuCreateOrderReception";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuOrderReceptionsApproval)>0)
{yield return "mnuOrderReceptionsApproval";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuOrders)>0)
{yield return "mnuOrders";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuAddStockManually)>0)
{yield return "mnuAddStockManually";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuAdjustStockManually)>0)
{yield return "mnuAdjustStockManually";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuMainInventory)>0)
{yield return "mnuMainInventory";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuProducts)>0)
{yield return "mnuProducts";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuSecurity)>0)
{yield return "mnuSecurity";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuAccounts)>0)
{yield return "mnuAccounts";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuAbout)>0)
{yield return "mnuAbout";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuHelp)>0)
{yield return "mnuHelp";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_MainMenu1)>0)
{yield return "MainMenu1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0)
{yield return "sbStatusBar_Panels_Panel1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel2)>0)
{yield return "sbStatusBar_Panels_Panel2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel3)>0)
{yield return "sbStatusBar_Panels_Panel3";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0)
{yield return "sbStatusBar";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "mnuCustomer":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuCustomer)>0;
case "mnuProviders":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuProviders)>0;
case "mnuExit":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuExit)>0;
case "mnuFile":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuFile)>0;
case "mnuCreateOrderRequest":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuCreateOrderRequest)>0;
case "mnuOrderRequestsApproval":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuOrderRequestsApproval)>0;
case "lExit2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lExit2)>0;
case "mnuCreateOrderReception":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuCreateOrderReception)>0;
case "mnuOrderReceptionsApproval":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuOrderReceptionsApproval)>0;
case "mnuOrders":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuOrders)>0;
case "mnuAddStockManually":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuAddStockManually)>0;
case "mnuAdjustStockManually":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuAdjustStockManually)>0;
case "mnuMainInventory":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuMainInventory)>0;
case "mnuProducts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuProducts)>0;
case "mnuSecurity":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuSecurity)>0;
case "mnuAccounts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuAccounts)>0;
case "mnuAbout":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuAbout)>0;
case "mnuHelp":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_mnuHelp)>0;
case "MainMenu1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_MainMenu1)>0;
case "sbStatusBar_Panels_Panel1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0;
case "sbStatusBar_Panels_Panel2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel2)>0;
case "sbStatusBar_Panels_Panel3":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel3)>0;
case "sbStatusBar":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["mnuCustomer"]=_Mobilize_References[3];
refs["mnuProviders"]=_Mobilize_References[4];
refs["mnuExit"]=_Mobilize_References[5];
refs["mnuFile"]=_Mobilize_References[6];
refs["mnuCreateOrderRequest"]=_Mobilize_References[7];
refs["mnuOrderRequestsApproval"]=_Mobilize_References[8];
refs["lExit2"]=_Mobilize_References[9];
refs["mnuCreateOrderReception"]=_Mobilize_References[10];
refs["mnuOrderReceptionsApproval"]=_Mobilize_References[11];
refs["mnuOrders"]=_Mobilize_References[12];
refs["mnuAddStockManually"]=_Mobilize_References[13];
refs["mnuAdjustStockManually"]=_Mobilize_References[14];
refs["mnuMainInventory"]=_Mobilize_References[15];
refs["mnuProducts"]=_Mobilize_References[16];
refs["mnuSecurity"]=_Mobilize_References[17];
refs["mnuAccounts"]=_Mobilize_References[18];
refs["mnuAbout"]=_Mobilize_References[19];
refs["mnuHelp"]=_Mobilize_References[20];
refs["MainMenu1"]=_Mobilize_References[21];
refs["sbStatusBar_Panels_Panel1"]=_Mobilize_References[22];
refs["sbStatusBar_Panels_Panel2"]=_Mobilize_References[23];
refs["sbStatusBar_Panels_Panel3"]=_Mobilize_References[24];
refs["sbStatusBar"]=_Mobilize_References[25];
return refs;
}
protected override void _Mobilize_CleanChanges()
{if(!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew||((Mobilize.WebMap.Common.Core.IObservable)this).RefCount>0)
{this._Mobilize_DirtyFlag_0=0;
this._Mobilize_LoadedFlag_0=0;
this._Mobilize_ControlFlag=0;
}
base._Mobilize_CleanChanges();}
protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
{foreach ( var baseRef in base._Mobilize_GetReferences()) {yield return baseRef;
}var ref_visualControls=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.visualControls);if(ref_visualControls!=null)yield return ref_visualControls;
var ref_components=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.components);if(ref_components!=null)yield return ref_components;
var ref_ToolTipMain=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.ToolTipMain);if(ref_ToolTipMain!=null)yield return ref_ToolTipMain;
var ref_mnuCustomer=(Mobilize.WebMap.Common.Core.IObservable)this.mnuCustomer;if(ref_mnuCustomer!=null)yield return ref_mnuCustomer;
var ref_mnuProviders=(Mobilize.WebMap.Common.Core.IObservable)this.mnuProviders;if(ref_mnuProviders!=null)yield return ref_mnuProviders;
var ref_mnuExit=(Mobilize.WebMap.Common.Core.IObservable)this.mnuExit;if(ref_mnuExit!=null)yield return ref_mnuExit;
var ref_mnuFile=(Mobilize.WebMap.Common.Core.IObservable)this.mnuFile;if(ref_mnuFile!=null)yield return ref_mnuFile;
var ref_mnuCreateOrderRequest=(Mobilize.WebMap.Common.Core.IObservable)this.mnuCreateOrderRequest;if(ref_mnuCreateOrderRequest!=null)yield return ref_mnuCreateOrderRequest;
var ref_mnuOrderRequestsApproval=(Mobilize.WebMap.Common.Core.IObservable)this.mnuOrderRequestsApproval;if(ref_mnuOrderRequestsApproval!=null)yield return ref_mnuOrderRequestsApproval;
var ref_lExit2=(Mobilize.WebMap.Common.Core.IObservable)this.lExit2;if(ref_lExit2!=null)yield return ref_lExit2;
var ref_mnuCreateOrderReception=(Mobilize.WebMap.Common.Core.IObservable)this.mnuCreateOrderReception;if(ref_mnuCreateOrderReception!=null)yield return ref_mnuCreateOrderReception;
var ref_mnuOrderReceptionsApproval=(Mobilize.WebMap.Common.Core.IObservable)this.mnuOrderReceptionsApproval;if(ref_mnuOrderReceptionsApproval!=null)yield return ref_mnuOrderReceptionsApproval;
var ref_mnuOrders=(Mobilize.WebMap.Common.Core.IObservable)this.mnuOrders;if(ref_mnuOrders!=null)yield return ref_mnuOrders;
var ref_mnuAddStockManually=(Mobilize.WebMap.Common.Core.IObservable)this.mnuAddStockManually;if(ref_mnuAddStockManually!=null)yield return ref_mnuAddStockManually;
var ref_mnuAdjustStockManually=(Mobilize.WebMap.Common.Core.IObservable)this.mnuAdjustStockManually;if(ref_mnuAdjustStockManually!=null)yield return ref_mnuAdjustStockManually;
var ref_mnuMainInventory=(Mobilize.WebMap.Common.Core.IObservable)this.mnuMainInventory;if(ref_mnuMainInventory!=null)yield return ref_mnuMainInventory;
var ref_mnuProducts=(Mobilize.WebMap.Common.Core.IObservable)this.mnuProducts;if(ref_mnuProducts!=null)yield return ref_mnuProducts;
var ref_mnuSecurity=(Mobilize.WebMap.Common.Core.IObservable)this.mnuSecurity;if(ref_mnuSecurity!=null)yield return ref_mnuSecurity;
var ref_mnuAccounts=(Mobilize.WebMap.Common.Core.IObservable)this.mnuAccounts;if(ref_mnuAccounts!=null)yield return ref_mnuAccounts;
var ref_mnuAbout=(Mobilize.WebMap.Common.Core.IObservable)this.mnuAbout;if(ref_mnuAbout!=null)yield return ref_mnuAbout;
var ref_mnuHelp=(Mobilize.WebMap.Common.Core.IObservable)this.mnuHelp;if(ref_mnuHelp!=null)yield return ref_mnuHelp;
var ref_MainMenu1=(Mobilize.WebMap.Common.Core.IObservable)this.MainMenu1;if(ref_MainMenu1!=null)yield return ref_MainMenu1;
var ref_sbStatusBar_Panels_Panel1=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar_Panels_Panel1;if(ref_sbStatusBar_Panels_Panel1!=null)yield return ref_sbStatusBar_Panels_Panel1;
var ref_sbStatusBar_Panels_Panel2=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar_Panels_Panel2;if(ref_sbStatusBar_Panels_Panel2!=null)yield return ref_sbStatusBar_Panels_Panel2;
var ref_sbStatusBar_Panels_Panel3=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar_Panels_Panel3;if(ref_sbStatusBar_Panels_Panel3!=null)yield return ref_sbStatusBar_Panels_Panel3;
var ref_sbStatusBar=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar;if(ref_sbStatusBar!=null)yield return ref_sbStatusBar;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_visualControls=(uint)1<<0;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<1;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_mnuCustomer=(uint)1<<3;
const uint _Mobilize_Loaded_mnuCustomer=(uint)1<<3;
const uint _Mobilize_Dirty_mnuProviders=(uint)1<<4;
const uint _Mobilize_Loaded_mnuProviders=(uint)1<<4;
const uint _Mobilize_Dirty_mnuExit=(uint)1<<5;
const uint _Mobilize_Loaded_mnuExit=(uint)1<<5;
const uint _Mobilize_Dirty_mnuFile=(uint)1<<6;
const uint _Mobilize_Loaded_mnuFile=(uint)1<<6;
const uint _Mobilize_Dirty_mnuCreateOrderRequest=(uint)1<<7;
const uint _Mobilize_Loaded_mnuCreateOrderRequest=(uint)1<<7;
const uint _Mobilize_Dirty_mnuOrderRequestsApproval=(uint)1<<8;
const uint _Mobilize_Loaded_mnuOrderRequestsApproval=(uint)1<<8;
const uint _Mobilize_Dirty_lExit2=(uint)1<<9;
const uint _Mobilize_Loaded_lExit2=(uint)1<<9;
const uint _Mobilize_Dirty_mnuCreateOrderReception=(uint)1<<10;
const uint _Mobilize_Loaded_mnuCreateOrderReception=(uint)1<<10;
const uint _Mobilize_Dirty_mnuOrderReceptionsApproval=(uint)1<<11;
const uint _Mobilize_Loaded_mnuOrderReceptionsApproval=(uint)1<<11;
const uint _Mobilize_Dirty_mnuOrders=(uint)1<<12;
const uint _Mobilize_Loaded_mnuOrders=(uint)1<<12;
const uint _Mobilize_Dirty_mnuAddStockManually=(uint)1<<13;
const uint _Mobilize_Loaded_mnuAddStockManually=(uint)1<<13;
const uint _Mobilize_Dirty_mnuAdjustStockManually=(uint)1<<14;
const uint _Mobilize_Loaded_mnuAdjustStockManually=(uint)1<<14;
const uint _Mobilize_Dirty_mnuMainInventory=(uint)1<<15;
const uint _Mobilize_Loaded_mnuMainInventory=(uint)1<<15;
const uint _Mobilize_Dirty_mnuProducts=(uint)1<<16;
const uint _Mobilize_Loaded_mnuProducts=(uint)1<<16;
const uint _Mobilize_Dirty_mnuSecurity=(uint)1<<17;
const uint _Mobilize_Loaded_mnuSecurity=(uint)1<<17;
const uint _Mobilize_Dirty_mnuAccounts=(uint)1<<18;
const uint _Mobilize_Loaded_mnuAccounts=(uint)1<<18;
const uint _Mobilize_Dirty_mnuAbout=(uint)1<<19;
const uint _Mobilize_Loaded_mnuAbout=(uint)1<<19;
const uint _Mobilize_Dirty_mnuHelp=(uint)1<<20;
const uint _Mobilize_Loaded_mnuHelp=(uint)1<<20;
const uint _Mobilize_Dirty_MainMenu1=(uint)1<<21;
const uint _Mobilize_Loaded_MainMenu1=(uint)1<<21;
const uint _Mobilize_Dirty_sbStatusBar_Panels_Panel1=(uint)1<<22;
const uint _Mobilize_Loaded_sbStatusBar_Panels_Panel1=(uint)1<<22;
const uint _Mobilize_Dirty_sbStatusBar_Panels_Panel2=(uint)1<<23;
const uint _Mobilize_Loaded_sbStatusBar_Panels_Panel2=(uint)1<<23;
const uint _Mobilize_Dirty_sbStatusBar_Panels_Panel3=(uint)1<<24;
const uint _Mobilize_Loaded_sbStatusBar_Panels_Panel3=(uint)1<<24;
const uint _Mobilize_Dirty_sbStatusBar=(uint)1<<25;
const uint _Mobilize_Loaded_sbStatusBar=(uint)1<<25;
private void Mobilize_Initialize_Properties()
{
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "mnuCustomer", "mnuProviders", "mnuExit", "mnuFile", "mnuCreateOrderRequest", "mnuOrderRequestsApproval", "lExit2", "mnuCreateOrderReception", "mnuOrderReceptionsApproval", "mnuOrders", "mnuAddStockManually", "mnuAdjustStockManually", "mnuMainInventory", "mnuProducts", "mnuSecurity", "mnuAccounts", "mnuAbout", "mnuHelp", "MainMenu1", "sbStatusBar_Panels_Panel1", "sbStatusBar_Panels_Panel2", "sbStatusBar_Panels_Panel3", "sbStatusBar"};
#line hidden
 }
#line 11
    


   	public frmMain()
   		: base()
   	{

#line hidden
this.Mobilize_Initialize_Properties();
#line 16
   		if (m_vb6FormDefInstance == null)
         {
         	m_vb6FormDefInstance = this;
         }
         //This call is required by the Windows Form Designer.
         InitializeComponent();
      }


      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      private void MDIForm_Load()
      {
         frmSplash.DefInstance.ShowDialog();
         frmOrderRequest.DefInstance.Show();


      }

      public void mnuAbout_Click(Object eventSender, EventArgs eventArgs)
      {
         frmAbout.DefInstance.ShowDialog(this);
      }

      public void mnuAddStockManually_Click(Object eventSender, EventArgs eventArgs)
      {
         frmAddStockManual.DefInstance.Show();
      }

      public void mnuAdjustStockManually_Click(Object eventSender, EventArgs eventArgs)
      {
         frmAdjustStockManual.DefInstance.Show();
      }

      public void mnuCreateOrderReception_Click(Object eventSender, EventArgs eventArgs)
      {
         frmOrderReception.DefInstance.Show();
      }

      public void mnuCreateOrderRequest_Click(Object eventSender, EventArgs eventArgs)
      {
         frmOrderRequest.DefInstance.Show();
      }

      public void mnuCustomer_Click(Object eventSender, EventArgs eventArgs)
      {
         frmCustomers.DefInstance.ShowDialog();
         frmCustomers.DefInstance.InitForm();
      }

      public void mnuExit_Click(Object eventSender, EventArgs eventArgs)
      {
         this.Close();
      }

      public void mnuOrderReceptionsApproval_Click(Object eventSender, EventArgs eventArgs)
      {
         frmReceptionApproval.DefInstance.Show();
      }

      public void mnuOrderRequestsApproval_Click(Object eventSender, EventArgs eventArgs)
      {
         frmRequestApproval.DefInstance.Show();
      }

      public void mnuProducts_Click(Object eventSender, EventArgs eventArgs)
      {
         frmProducts.DefInstance.ShowDialog();
      }

      public void mnuProviders_Click(Object eventSender, EventArgs eventArgs)
      {
         frmProviders.DefInstance.ShowDialog();
      }

      public void mnuSecurity_Click(Object eventSender, EventArgs eventArgs)
      {
         frmUsersManage.DefInstance.Show();
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
private SKS.frmMain m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmMain>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmMain>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmMain)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmMain)value;}}
#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool m_InitializingDefInstance_k__BackingField;
internal bool m_InitializingDefInstance {get
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.m_InitializingDefInstance_k__BackingField;}set
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_InitializingDefInstance;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_InitializingDefInstance_k__BackingField=(bool)value;}}}   	//UPGRADE_NOTE: (7001) The following declaration (Form_Unload) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
   	//private void Form_Unload(int Cancel)
   	//{
   	//}

   }
}
#pragma warning restore
