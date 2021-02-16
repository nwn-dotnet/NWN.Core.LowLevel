//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public unsafe class CBaseExoApp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CBaseExoApp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CBaseExoApp(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CBaseExoApp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CBaseExoApp() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CBaseExoApp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CBaseExoApp self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CBaseExoApp self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CBaseExoApp other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CBaseExoApp other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CBaseExoApp left, CBaseExoApp right) {
    return Equals(left, right);
  }

  public static bool operator !=(CBaseExoApp left, CBaseExoApp right) {
    return !Equals(left, right);
  }

  public virtual int AdmitNetworkAddress(uint nProtocol, CExoString sAddress) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_AdmitNetworkAddress(swigCPtr, nProtocol, CExoString.getCPtr(sAddress));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int AdmitPlayerName(CExoString sPlayerName) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_AdmitPlayerName(swigCPtr, CExoString.getCPtr(sPlayerName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int SetNetworkAddressBan(uint nProtocol, CExoString sAddress, int bBanPlayer) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_SetNetworkAddressBan(swigCPtr, nProtocol, CExoString.getCPtr(sAddress), bBanPlayer);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void PlayerListChange(uint nPlayerId, int bEnter, int bPrimaryPlayer) {
    NWNXLibPINVOKE.CBaseExoApp_PlayerListChange__SWIG_0(swigCPtr, nPlayerId, bEnter, bPrimaryPlayer);
  }

  public virtual void PlayerListChange(uint nPlayerId, int bEnter) {
    NWNXLibPINVOKE.CBaseExoApp_PlayerListChange__SWIG_1(swigCPtr, nPlayerId, bEnter);
  }

  public virtual int HandleMessage(uint nPlayerId, byte* pData, uint dwSize, int bRawMessage) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_HandleMessage(swigCPtr, nPlayerId, (global::System.IntPtr)pData, dwSize, bRawMessage);
    return ret;
  }

  public virtual float GetFPS() {
    float ret = NWNXLibPINVOKE.CBaseExoApp_GetFPS(swigCPtr);
    return ret;
  }

  public virtual int ContinueMessageProcessing() {
    int ret = NWNXLibPINVOKE.CBaseExoApp_ContinueMessageProcessing(swigCPtr);
    return ret;
  }

  public virtual CNetLayer GetNetLayer() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CBaseExoApp_GetNetLayer(swigCPtr);
    CNetLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNetLayer(cPtr, false);
    return ret;
  }

  public virtual void ShutDownToMainMenu() {
    NWNXLibPINVOKE.CBaseExoApp_ShutDownToMainMenu(swigCPtr);
  }

  public virtual int GetMultiplayerEnabled() {
    int ret = NWNXLibPINVOKE.CBaseExoApp_GetMultiplayerEnabled(swigCPtr);
    return ret;
  }

  public virtual CExtendedServerInfo GetExtendedServerInfo() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CBaseExoApp_GetExtendedServerInfo__SWIG_0(swigCPtr);
    CExtendedServerInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExtendedServerInfo(cPtr, false);
    return ret;
  }

  public virtual void HandleGameSpyToServerMessage(int nKeyId, void* pOutBuf, int nIndex) {
    NWNXLibPINVOKE.CBaseExoApp_HandleGameSpyToServerMessage__SWIG_0(swigCPtr, nKeyId, (global::System.IntPtr)pOutBuf, nIndex);
  }

  public virtual void HandleGameSpyToServerMessage(int nKeyId, void* pOutBuf) {
    NWNXLibPINVOKE.CBaseExoApp_HandleGameSpyToServerMessage__SWIG_1(swigCPtr, nKeyId, (global::System.IntPtr)pOutBuf);
  }

  public virtual SWIGTYPE_p_CConnectionLib GetConnectionLib() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CBaseExoApp_GetConnectionLib(swigCPtr);
    SWIGTYPE_p_CConnectionLib ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CConnectionLib(cPtr, false);
    return ret;
  }

  public virtual CServerInfo GetServerInfo() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CBaseExoApp_GetServerInfo(swigCPtr);
    CServerInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerInfo(cPtr, false);
    return ret;
  }

  public virtual void GetExtendedServerInfo(CExtendedServerInfo pInfo) {
    NWNXLibPINVOKE.CBaseExoApp_GetExtendedServerInfo__SWIG_1(swigCPtr, CExtendedServerInfo.getCPtr(pInfo));
  }

  public virtual CExoLocString GetModuleDescription() {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CBaseExoApp_GetModuleDescription(swigCPtr), true);
    return ret;
  }

  public virtual uint GetApplicationId() {
    uint ret = NWNXLibPINVOKE.CBaseExoApp_GetApplicationId(swigCPtr);
    return ret;
  }

  public virtual void SetApplicationIdsMatch(int b) {
    NWNXLibPINVOKE.CBaseExoApp_SetApplicationIdsMatch(swigCPtr, b);
  }

  public virtual int GetIsIPOnBannedList(CExoString sIP) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_GetIsIPOnBannedList(swigCPtr, CExoString.getCPtr(sIP));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetIsPlayerNameOnBannedList(CExoString sPlayerName) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_GetIsPlayerNameOnBannedList(swigCPtr, CExoString.getCPtr(sPlayerName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetIsCDKeyOnBannedList(CExoString sKey) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_GetIsCDKeyOnBannedList(swigCPtr, CExoString.getCPtr(sKey));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void HandleOldServerVaultMigration(CExoString sClientCDKey, CExoString sClientLegacyCDKey, CExoString sPlayerName) {
    NWNXLibPINVOKE.CBaseExoApp_HandleOldServerVaultMigration(swigCPtr, CExoString.getCPtr(sClientCDKey), CExoString.getCPtr(sClientLegacyCDKey), CExoString.getCPtr(sPlayerName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int IsPlayerNameSticky() {
    int ret = NWNXLibPINVOKE.CBaseExoApp_IsPlayerNameSticky(swigCPtr);
    return ret;
  }

  public virtual int CheckStickyPlayerNameReserved(CExoString sClientCDKey, CExoString sClientLegacyCDKey, CExoString sPlayerName, int nConnectionType) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_CheckStickyPlayerNameReserved(swigCPtr, CExoString.getCPtr(sClientCDKey), CExoString.getCPtr(sClientLegacyCDKey), CExoString.getCPtr(sPlayerName), nConnectionType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void PushMessageOverWall(byte* pData, uint nMsgLength) {
    NWNXLibPINVOKE.CBaseExoApp_PushMessageOverWall(swigCPtr, (global::System.IntPtr)pData, nMsgLength);
  }

  public virtual int GetIsMultiPlayer() {
    int ret = NWNXLibPINVOKE.CBaseExoApp_GetIsMultiPlayer(swigCPtr);
    return ret;
  }

  public virtual int GetCDKeys(SWIGTYPE_p_p_CExoArrayListT_CExoString_t lstKeys) {
    int ret = NWNXLibPINVOKE.CBaseExoApp_GetCDKeys(swigCPtr, SWIGTYPE_p_p_CExoArrayListT_CExoString_t.getCPtr(lstKeys));
    return ret;
  }

  public virtual void SetWeGotDisconnected() {
    NWNXLibPINVOKE.CBaseExoApp_SetWeGotDisconnected(swigCPtr);
  }

}

}
