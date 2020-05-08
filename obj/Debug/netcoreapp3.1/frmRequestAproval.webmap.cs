#pragma warning disable
#line 1 "frmRequestAproval.cs"
#pragma warning disable
#line 1 "frmRequestAproval.cs"
using System;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmRequestApproval
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[30];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Id)>0)
{yield return "Id";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdApprove)>0)
{yield return "cmdApprove";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdInfo)>0)
{yield return "cmdInfo";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_fgOrders)>0)
{yield return "fgOrders";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmbStatus)>0)
{yield return "cmbStatus";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_chkTo)>0)
{yield return "chkTo";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_chkFrom)>0)
{yield return "chkFrom";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProductID)>0)
{yield return "txtProductID";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtOrderID)>0)
{yield return "txtOrderID";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtContactLastName)>0)
{yield return "txtContactLastName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtContactName)>0)
{yield return "txtContactName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdCustomers)>0)
{yield return "cmdCustomers";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtCompanyName)>0)
{yield return "txtCompanyName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_dtFrom)>0)
{yield return "dtFrom";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_dtTo)>0)
{yield return "dtTo";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label5)>0)
{yield return "Label5";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label8)>0)
{yield return "Label8";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label1)>0)
{yield return "Label1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label6)>0)
{yield return "Label6";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label3)>0)
{yield return "Label3";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0)
{yield return "Label4";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label2)>0)
{yield return "Label2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame1)>0)
{yield return "Frame1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_listBoxComboBoxHelper1)>0)
{yield return "listBoxComboBoxHelper1";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "Id":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Id)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "cmdApprove":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdApprove)>0;
case "cmdInfo":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdInfo)>0;
case "fgOrders":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_fgOrders)>0;
case "sbStatusBar_Panels_Panel1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar_Panels_Panel1)>0;
case "sbStatusBar":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_sbStatusBar)>0;
case "cmdCancel":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdCancel)>0;
case "cmdClose":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0;
case "cmbStatus":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmbStatus)>0;
case "chkTo":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_chkTo)>0;
case "chkFrom":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_chkFrom)>0;
case "txtProductID":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtProductID)>0;
case "txtOrderID":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtOrderID)>0;
case "txtContactLastName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtContactLastName)>0;
case "txtContactName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtContactName)>0;
case "cmdCustomers":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdCustomers)>0;
case "txtCompanyName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtCompanyName)>0;
case "dtFrom":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_dtFrom)>0;
case "dtTo":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_dtTo)>0;
case "Label5":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label5)>0;
case "Label8":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label8)>0;
case "Label1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label1)>0;
case "Label6":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label6)>0;
case "Label3":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label3)>0;
case "Label4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0;
case "Label2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label2)>0;
case "Frame1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame1)>0;
case "listBoxComboBoxHelper1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_listBoxComboBoxHelper1)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["cmdApprove"]=_Mobilize_References[3];
refs["cmdInfo"]=_Mobilize_References[4];
refs["fgOrders"]=_Mobilize_References[5];
refs["sbStatusBar_Panels_Panel1"]=_Mobilize_References[6];
refs["sbStatusBar"]=_Mobilize_References[7];
refs["cmdCancel"]=_Mobilize_References[8];
refs["cmdClose"]=_Mobilize_References[9];
refs["cmbStatus"]=_Mobilize_References[10];
refs["chkTo"]=_Mobilize_References[11];
refs["chkFrom"]=_Mobilize_References[12];
refs["txtProductID"]=_Mobilize_References[13];
refs["txtOrderID"]=_Mobilize_References[14];
refs["txtContactLastName"]=_Mobilize_References[15];
refs["txtContactName"]=_Mobilize_References[16];
refs["cmdCustomers"]=_Mobilize_References[17];
refs["txtCompanyName"]=_Mobilize_References[18];
refs["dtFrom"]=_Mobilize_References[19];
refs["dtTo"]=_Mobilize_References[20];
refs["Label5"]=_Mobilize_References[21];
refs["Label8"]=_Mobilize_References[22];
refs["Label1"]=_Mobilize_References[23];
refs["Label6"]=_Mobilize_References[24];
refs["Label3"]=_Mobilize_References[25];
refs["Label4"]=_Mobilize_References[26];
refs["Label2"]=_Mobilize_References[27];
refs["Frame1"]=_Mobilize_References[28];
refs["listBoxComboBoxHelper1"]=_Mobilize_References[29];
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
var ref_cmdApprove=(Mobilize.WebMap.Common.Core.IObservable)this.cmdApprove;if(ref_cmdApprove!=null)yield return ref_cmdApprove;
var ref_cmdInfo=(Mobilize.WebMap.Common.Core.IObservable)this.cmdInfo;if(ref_cmdInfo!=null)yield return ref_cmdInfo;
var ref_fgOrders=(Mobilize.WebMap.Common.Core.IObservable)this.fgOrders;if(ref_fgOrders!=null)yield return ref_fgOrders;
var ref_sbStatusBar_Panels_Panel1=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar_Panels_Panel1;if(ref_sbStatusBar_Panels_Panel1!=null)yield return ref_sbStatusBar_Panels_Panel1;
var ref_sbStatusBar=(Mobilize.WebMap.Common.Core.IObservable)this.sbStatusBar;if(ref_sbStatusBar!=null)yield return ref_sbStatusBar;
var ref_cmdCancel=(Mobilize.WebMap.Common.Core.IObservable)this.cmdCancel;if(ref_cmdCancel!=null)yield return ref_cmdCancel;
var ref_cmdClose=(Mobilize.WebMap.Common.Core.IObservable)this.cmdClose;if(ref_cmdClose!=null)yield return ref_cmdClose;
var ref_cmbStatus=(Mobilize.WebMap.Common.Core.IObservable)this.cmbStatus;if(ref_cmbStatus!=null)yield return ref_cmbStatus;
var ref_chkTo=(Mobilize.WebMap.Common.Core.IObservable)this.chkTo;if(ref_chkTo!=null)yield return ref_chkTo;
var ref_chkFrom=(Mobilize.WebMap.Common.Core.IObservable)this.chkFrom;if(ref_chkFrom!=null)yield return ref_chkFrom;
var ref_txtProductID=(Mobilize.WebMap.Common.Core.IObservable)this.txtProductID;if(ref_txtProductID!=null)yield return ref_txtProductID;
var ref_txtOrderID=(Mobilize.WebMap.Common.Core.IObservable)this.txtOrderID;if(ref_txtOrderID!=null)yield return ref_txtOrderID;
var ref_txtContactLastName=(Mobilize.WebMap.Common.Core.IObservable)this.txtContactLastName;if(ref_txtContactLastName!=null)yield return ref_txtContactLastName;
var ref_txtContactName=(Mobilize.WebMap.Common.Core.IObservable)this.txtContactName;if(ref_txtContactName!=null)yield return ref_txtContactName;
var ref_cmdCustomers=(Mobilize.WebMap.Common.Core.IObservable)this.cmdCustomers;if(ref_cmdCustomers!=null)yield return ref_cmdCustomers;
var ref_txtCompanyName=(Mobilize.WebMap.Common.Core.IObservable)this.txtCompanyName;if(ref_txtCompanyName!=null)yield return ref_txtCompanyName;
var ref_dtFrom=(Mobilize.WebMap.Common.Core.IObservable)this.dtFrom;if(ref_dtFrom!=null)yield return ref_dtFrom;
var ref_dtTo=(Mobilize.WebMap.Common.Core.IObservable)this.dtTo;if(ref_dtTo!=null)yield return ref_dtTo;
var ref_Label5=(Mobilize.WebMap.Common.Core.IObservable)this.Label5;if(ref_Label5!=null)yield return ref_Label5;
var ref_Label8=(Mobilize.WebMap.Common.Core.IObservable)this.Label8;if(ref_Label8!=null)yield return ref_Label8;
var ref_Label1=(Mobilize.WebMap.Common.Core.IObservable)this.Label1;if(ref_Label1!=null)yield return ref_Label1;
var ref_Label6=(Mobilize.WebMap.Common.Core.IObservable)this.Label6;if(ref_Label6!=null)yield return ref_Label6;
var ref_Label3=(Mobilize.WebMap.Common.Core.IObservable)this.Label3;if(ref_Label3!=null)yield return ref_Label3;
var ref_Label4=(Mobilize.WebMap.Common.Core.IObservable)this.Label4;if(ref_Label4!=null)yield return ref_Label4;
var ref_Label2=(Mobilize.WebMap.Common.Core.IObservable)this.Label2;if(ref_Label2!=null)yield return ref_Label2;
var ref_Frame1=(Mobilize.WebMap.Common.Core.IObservable)this.Frame1;if(ref_Frame1!=null)yield return ref_Frame1;
var ref_listBoxComboBoxHelper1=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.listBoxComboBoxHelper1);if(ref_listBoxComboBoxHelper1!=null)yield return ref_listBoxComboBoxHelper1;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_Id=(uint)1<<0;
const uint _Mobilize_Dirty_visualControls=(uint)1<<1;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<2;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<3;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_cmdApprove=(uint)1<<4;
const uint _Mobilize_Loaded_cmdApprove=(uint)1<<3;
const uint _Mobilize_Dirty_cmdInfo=(uint)1<<5;
const uint _Mobilize_Loaded_cmdInfo=(uint)1<<4;
const uint _Mobilize_Dirty_fgOrders=(uint)1<<6;
const uint _Mobilize_Loaded_fgOrders=(uint)1<<5;
const uint _Mobilize_Dirty_sbStatusBar_Panels_Panel1=(uint)1<<7;
const uint _Mobilize_Loaded_sbStatusBar_Panels_Panel1=(uint)1<<6;
const uint _Mobilize_Dirty_sbStatusBar=(uint)1<<8;
const uint _Mobilize_Loaded_sbStatusBar=(uint)1<<7;
const uint _Mobilize_Dirty_cmdCancel=(uint)1<<9;
const uint _Mobilize_Loaded_cmdCancel=(uint)1<<8;
const uint _Mobilize_Dirty_cmdClose=(uint)1<<10;
const uint _Mobilize_Loaded_cmdClose=(uint)1<<9;
const uint _Mobilize_Dirty_cmbStatus=(uint)1<<11;
const uint _Mobilize_Loaded_cmbStatus=(uint)1<<10;
const uint _Mobilize_Dirty_chkTo=(uint)1<<12;
const uint _Mobilize_Loaded_chkTo=(uint)1<<11;
const uint _Mobilize_Dirty_chkFrom=(uint)1<<13;
const uint _Mobilize_Loaded_chkFrom=(uint)1<<12;
const uint _Mobilize_Dirty_txtProductID=(uint)1<<14;
const uint _Mobilize_Loaded_txtProductID=(uint)1<<13;
const uint _Mobilize_Dirty_txtOrderID=(uint)1<<15;
const uint _Mobilize_Loaded_txtOrderID=(uint)1<<14;
const uint _Mobilize_Dirty_txtContactLastName=(uint)1<<16;
const uint _Mobilize_Loaded_txtContactLastName=(uint)1<<15;
const uint _Mobilize_Dirty_txtContactName=(uint)1<<17;
const uint _Mobilize_Loaded_txtContactName=(uint)1<<16;
const uint _Mobilize_Dirty_cmdCustomers=(uint)1<<18;
const uint _Mobilize_Loaded_cmdCustomers=(uint)1<<17;
const uint _Mobilize_Dirty_txtCompanyName=(uint)1<<19;
const uint _Mobilize_Loaded_txtCompanyName=(uint)1<<18;
const uint _Mobilize_Dirty_dtFrom=(uint)1<<20;
const uint _Mobilize_Loaded_dtFrom=(uint)1<<19;
const uint _Mobilize_Dirty_dtTo=(uint)1<<21;
const uint _Mobilize_Loaded_dtTo=(uint)1<<20;
const uint _Mobilize_Dirty_Label5=(uint)1<<22;
const uint _Mobilize_Loaded_Label5=(uint)1<<21;
const uint _Mobilize_Dirty_Label8=(uint)1<<23;
const uint _Mobilize_Loaded_Label8=(uint)1<<22;
const uint _Mobilize_Dirty_Label1=(uint)1<<24;
const uint _Mobilize_Loaded_Label1=(uint)1<<23;
const uint _Mobilize_Dirty_Label6=(uint)1<<25;
const uint _Mobilize_Loaded_Label6=(uint)1<<24;
const uint _Mobilize_Dirty_Label3=(uint)1<<26;
const uint _Mobilize_Loaded_Label3=(uint)1<<25;
const uint _Mobilize_Dirty_Label4=(uint)1<<27;
const uint _Mobilize_Loaded_Label4=(uint)1<<26;
const uint _Mobilize_Dirty_Label2=(uint)1<<28;
const uint _Mobilize_Loaded_Label2=(uint)1<<27;
const uint _Mobilize_Dirty_Frame1=(uint)1<<29;
const uint _Mobilize_Loaded_Frame1=(uint)1<<28;
const uint _Mobilize_Dirty_listBoxComboBoxHelper1=(uint)1<<30;
const uint _Mobilize_Loaded_listBoxComboBoxHelper1=(uint)1<<29;
private void Mobilize_Initialize_Properties()
{
#line 17
                                      this.Id="";
#line hidden
 
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "cmdApprove", "cmdInfo", "fgOrders", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "cmbStatus", "chkTo", "chkFrom", "txtProductID", "txtOrderID", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "dtFrom", "dtTo", "Label5", "Label8", "Label1", "Label6", "Label3", "Label4", "Label2", "Frame1", "listBoxComboBoxHelper1"};
#line hidden
 }
#line 13
    

#line hidden
                                      
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Id_k__BackingField;
#line 17
                                      

      [Intercepted]

      private string Id 
#line 17
                        { 
#line 17
                          get                             
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Id_k__BackingField;} 
#line 17

#line 17
                               set                                  
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Id;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Id_k__BackingField=(string)value;} 
#line 17
                                    } 
#line 18


      public frmRequestApproval()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 22
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




      private void cmbStatus_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchRequest();
      }

      private void cmdApprove_Click(Object eventSender, EventArgs eventArgs)
      {
      	LoadActionOrderRequest(1);
      }

      private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
      {
      	LoadActionOrderRequest(2);
      }

      private void cmdInfo_Click(Object eventSender, EventArgs eventArgs)
      {
      	LoadActionOrderRequest();
      }

      private void LoadActionOrderRequest(int Action = 0)
      {
      	int OrderId = 0;
      	if (fgOrders.CurrentRowIndex > 0)
      	{
      		OrderId = Convert.ToInt32(Double.Parse(Convert.ToString(fgOrders[fgOrders.CurrentRowIndex, 1].Value)));
      		frmActionOrderRequest.DefInstance.OrderId = OrderId;
      		frmActionOrderRequest.DefInstance.Action = Action;
      		frmActionOrderRequest.DefInstance.LoadData();
      		frmActionOrderRequest.DefInstance.Show();
      	}
      }

      private void dtFrom_ValueChanged(Object eventSender, EventArgs eventArgs)
      {
      	chkFrom.CheckState = Mobilize.Web.CheckState.Checked;
         DoSearchRequest();
      }

      private void dtTo_ValueChanged(Object eventSender, EventArgs eventArgs)
      {
      	chkTo.CheckState = Mobilize.Web.CheckState.Checked;
         DoSearchRequest();
      }


      private void fgOrders_DoubleClick(Object eventSender, EventArgs eventArgs)
      {
      	cmdInfo_Click(cmdInfo, new EventArgs());
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080

      private void Form_Load()
      {
      	InitGrid();
      }

      private void txtOrderID_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchRequest();
      }

      private void txtProductID_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchRequest();
      }

      private void txtCompanyName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchRequest();
      }

      private void txtContactLastName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchRequest();
      }

      private void txtContactName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	DoSearchRequest();
      }

      //UPGRADE_NOTE: (7001) The following declaration (txtName_Change) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
      //private void txtName_Change()
      //{
      	//DoSearchRequest();
      //}

      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
      	this.Close();
      }

      private void cmdCustomers_Click(Object eventSender, EventArgs eventArgs)
      {
      	frmCustomers.DefInstance.ShowDialog();
      	txtCompanyName.Text = "";
      	txtContactLastName.Text = "";
      	txtContactName.Text = "";
      	DoSearchRequest(Convert.ToInt32(Double.Parse(frmCustomers.DefInstance.CurrentCustomerID)));
      	frmCustomers.DefInstance.Close();
      }

      private void DoSearchRequest(int Id = -1)
      {
      	string filter = "";
      	if (Id != -1)
         {
         	filter = "o.CustomerID = " + Id.ToString();
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!String.IsNullOrEmpty(txtCompanyName.Text))
         {
         	modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = "c.CompanyName LIKE '%" + txtCompanyName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!String.IsNullOrEmpty(txtContactName.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "c.ContactFirstName LIKE '%" + txtContactName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!String.IsNullOrEmpty(txtContactLastName.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "c.ContactLastName LIKE '%" + txtContactLastName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!String.IsNullOrEmpty(txtOrderID.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "o.OrderID = " + txtOrderID.Text;
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!String.IsNullOrEmpty(txtProductID.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "d.ProductID LIKE '%" + txtProductID.Text + "%'";
         }
         if (chkFrom.CheckState == Mobilize.Web.CheckState.Checked)
         {
         	modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "o.OrderDate >= '" + ReflectionHelper.GetPrimitiveValue<System.DateTime>(dtFrom.GetValue()).ToString("MM/dd/yyyy") + "'";
         }
         if (chkTo.CheckState == Mobilize.Web.CheckState.Checked)
         {
         	modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "o.OrderDate <= '" + ReflectionHelper.GetPrimitiveValue<System.DateTime>(dtTo.GetValue()).ToString("MM/dd/yyyy") + "'";
         }
         if (cmbStatus.SelectedIndex != -1 && cmbStatus.Text != "All")
         {
         	modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "o.Status = UPPER('" + cmbStatus.Text + "')";
         }

         string where = " Where o.OrderID = d.OrderID And c.CustomerID = o.CustomerID And u.Username = o.EmployeeId ";
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!String.IsNullOrEmpty(filter))
         {
            filter = where + " AND " + filter;
         }
         else
         {
            filter = where;
         }


         string sql = "Select o.OrderDate, o.OrderID, c.CompanyName, c.ContactFirstName + ' ' + c.ContactLastName as ContactName, u.Fullname as [Received by], Sum(d.LineTotal) as Price, o.Status " +
                      "From OrderRequests as o, OrderRequestDetails as d, Customers as c, Users as u " +
                      filter + " Group by o.orderDate, o.OrderID, c.CompanyName, c.ContactFirstName + ' ' + c.ContactLastName, u.Fullname, o.Status ";
         modConnection.ExecuteSql(sql);
         modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
         int i = 0;
         fgOrders.RowsCount = modConnection.rs.RecordCount + 1;
         if (fgOrders.RowsCount == 1)
         {
         	fgOrders.FixedRows = 0;
         }
         else
         {
         	fgOrders.FixedRows = 1;
         }
         i = 1;
         while (!modConnection.rs.EOF)
         {
         	int tempForEndVar = modConnection.rs.FieldsMetadata.Count - 1;
         	for (int j = 0; j <= tempForEndVar; j++)
         	{
         		if (modConnection.rs.GetField(j) != null)
               {
               	fgOrders[i, j].Value = Convert.ToString(modConnection.rs[j]);
               }
            }
            modConnection.rs.MoveNext();
            i++;
         }
      }

      private void InitGrid()
      {
      	fgOrders.RowsCount = 0;
      	fgOrders.ColumnsCount = 7;
      	fgOrders.FixedColumns = 0;
      	fgOrders.AddItem("Date" + "\t" + "Order" + "\t" + "Customer" + "\t" + "Contact" + "\t" + "Received by" + "\t" + "Price" + "\t" + "Status");
      	fgOrders.RowsCount = 1;
      	fgOrders.FixedRows = 0;
      	fgOrders.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.FullRowSelect;
      }

      //'''''''''''''''''''''''''''''
      //''UNUSED CODE Start



      //UPGRADE_NOTE: (7001) The following declaration (MakeTextBoxVisible) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
      //private void MakeTextBoxVisible(TextBox txtBox, UpgradeHelpers.DataGridViewFlex grid)
      //{
      	//txtBox.Text = Convert.ToString(grid[grid.CurrentRowIndex, grid.CurrentColumnIndex].Value);
      	//txtBox.SetBounds(grid.CellLeft / 15 + grid.Left, grid.CellTop / 15 + grid.Top, grid.CellWidth / 15, grid.CellHeight / 15);
      	//txtBox.Visible = true;
      	//Application.DoEvents();
      	//txtBox.Focus();
      //}

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
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
private SKS.frmRequestApproval m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmRequestApproval>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmRequestApproval>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmRequestApproval)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmRequestApproval)value;}}
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
