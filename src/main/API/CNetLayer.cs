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

public unsafe class CNetLayer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNetLayer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNetLayer(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNetLayer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNetLayer() {
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
          NWNXLibPINVOKE.delete_CNetLayer(swigCPtr);
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

  public static unsafe implicit operator void*(CNetLayer self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNetLayer self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNetLayer other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNetLayer other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNetLayer left, CNetLayer right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNetLayer left, CNetLayer right) {
    return !Equals(left, right);
  }

  public SWIGTYPE_p_CNetLayerInternal m_pcNetLayerInternal {
    set {
      NWNXLibPINVOKE.CNetLayer_m_pcNetLayerInternal_set(swigCPtr, SWIGTYPE_p_CNetLayerInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayer_m_pcNetLayerInternal_get(swigCPtr);
      SWIGTYPE_p_CNetLayerInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CNetLayerInternal(cPtr, false);
      return ret;
    } 
  }

  public CNetLayer() : this(NWNXLibPINVOKE.new_CNetLayer(), true) {
  }

  public int Initialize(CBaseExoApp pcExoApp) {
    int ret = NWNXLibPINVOKE.CNetLayer_Initialize(swigCPtr, CBaseExoApp.getCPtr(pcExoApp));
    return ret;
  }

  public CBaseExoApp GetExoApp() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayer_GetExoApp(swigCPtr);
    CBaseExoApp ret = (cPtr == global::System.IntPtr.Zero) ? null : new CBaseExoApp(cPtr, false);
    return ret;
  }

  public int ShutDown() {
    int ret = NWNXLibPINVOKE.CNetLayer_ShutDown(swigCPtr);
    return ret;
  }

  public int StartProtocol(uint nProtocol, uint nSendingAddress, uint nReceivingAddress, uint nInstance) {
    int ret = NWNXLibPINVOKE.CNetLayer_StartProtocol(swigCPtr, nProtocol, nSendingAddress, nReceivingAddress, nInstance);
    return ret;
  }

  public int EndProtocol(uint nProtocol) {
    int ret = NWNXLibPINVOKE.CNetLayer_EndProtocol(swigCPtr, nProtocol);
    return ret;
  }

  public void SetServerLanguage(int nLanguage) {
    NWNXLibPINVOKE.CNetLayer_SetServerLanguage(swigCPtr, nLanguage);
  }

  public int StartServerMode(CExoString sSessionName, uint nMaxPlayers) {
    int ret = NWNXLibPINVOKE.CNetLayer_StartServerMode(swigCPtr, CExoString.getCPtr(sSessionName), nMaxPlayers);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetPasswordRequired() {
    int ret = NWNXLibPINVOKE.CNetLayer_GetPasswordRequired(swigCPtr);
    return ret;
  }

  public CExoString GetPlayerPassword() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetPlayerPassword(swigCPtr), true);
    return ret;
  }

  public int SetPlayerPassword(CExoString sPlayerPassword) {
    int ret = NWNXLibPINVOKE.CNetLayer_SetPlayerPassword(swigCPtr, CExoString.getCPtr(sPlayerPassword));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString GetGameMasterPassword() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetGameMasterPassword(swigCPtr), true);
    return ret;
  }

  public int SetGameMasterPassword(CExoString sGameMasterPassowrd) {
    int ret = NWNXLibPINVOKE.CNetLayer_SetGameMasterPassword(swigCPtr, CExoString.getCPtr(sGameMasterPassowrd));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString GetServerAdminPassword() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetServerAdminPassword(swigCPtr), true);
    return ret;
  }

  public int SetServerAdminPassword(CExoString sServerAdminPassword) {
    int ret = NWNXLibPINVOKE.CNetLayer_SetServerAdminPassword(swigCPtr, CExoString.getCPtr(sServerAdminPassword));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int EndServerMode() {
    int ret = NWNXLibPINVOKE.CNetLayer_EndServerMode(swigCPtr);
    return ret;
  }

  public int GetServerConnected() {
    int ret = NWNXLibPINVOKE.CNetLayer_GetServerConnected(swigCPtr);
    return ret;
  }

  public CNetLayerPlayerInfo GetPlayerInfo(uint nPlayerId) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayer_GetPlayerInfo(swigCPtr, nPlayerId);
    CNetLayerPlayerInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNetLayerPlayerInfo(cPtr, false);
    return ret;
  }

  public CExoString GetPlayerAddress(uint nPlayerId, int bIncludePort) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetPlayerAddress__SWIG_0(swigCPtr, nPlayerId, bIncludePort), true);
    return ret;
  }

  public CExoString GetPlayerAddress(uint nPlayerId) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetPlayerAddress__SWIG_1(swigCPtr, nPlayerId), true);
    return ret;
  }

  public int GetPlayerAddressRelayed(uint nPlayerId) {
    int ret = NWNXLibPINVOKE.CNetLayer_GetPlayerAddressRelayed(swigCPtr, nPlayerId);
    return ret;
  }

  public int DisconnectPlayer(uint nPlayerId, uint nStrRef, int bCDAuthFail, CExoString reason) {
    int ret = NWNXLibPINVOKE.CNetLayer_DisconnectPlayer__SWIG_0(swigCPtr, nPlayerId, nStrRef, bCDAuthFail, CExoString.getCPtr(reason));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int DisconnectPlayer(uint nPlayerId, uint nStrRef, int bCDAuthFail) {
    int ret = NWNXLibPINVOKE.CNetLayer_DisconnectPlayer__SWIG_1(swigCPtr, nPlayerId, nStrRef, bCDAuthFail);
    return ret;
  }

  public int DisconnectPlayer(uint nPlayerId, uint nStrRef) {
    int ret = NWNXLibPINVOKE.CNetLayer_DisconnectPlayer__SWIG_2(swigCPtr, nPlayerId, nStrRef);
    return ret;
  }

  public int DisconnectPlayer(uint nPlayerId) {
    int ret = NWNXLibPINVOKE.CNetLayer_DisconnectPlayer__SWIG_3(swigCPtr, nPlayerId);
    return ret;
  }

  public uint GetDisconnectStrref() {
    uint ret = NWNXLibPINVOKE.CNetLayer_GetDisconnectStrref(swigCPtr);
    return ret;
  }

  public void SetDisconnectStrref(uint nStrref) {
    NWNXLibPINVOKE.CNetLayer_SetDisconnectStrref(swigCPtr, nStrref);
  }

  public CExoString GetDisconnectReason() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetDisconnectReason(swigCPtr), true);
    return ret;
  }

  public void SetDisconnectReason(CExoString sReason) {
    NWNXLibPINVOKE.CNetLayer_SetDisconnectReason(swigCPtr, CExoString.getCPtr(sReason));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetUpPlayBackConnection() {
    NWNXLibPINVOKE.CNetLayer_SetUpPlayBackConnection(swigCPtr);
  }

  public void StartAddressTranslation(CExoString sInternetAddress) {
    NWNXLibPINVOKE.CNetLayer_StartAddressTranslation(swigCPtr, CExoString.getCPtr(sInternetAddress));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetAddressTranslationResult(CExoString sInternetAddress, CExoArrayListUInt32 nIPv4) {
    int ret = NWNXLibPINVOKE.CNetLayer_GetAddressTranslationResult(swigCPtr, CExoString.getCPtr(sInternetAddress), CExoArrayListUInt32.getCPtr(nIPv4));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void EndAddressTranslation(CExoString sInternetAddress) {
    NWNXLibPINVOKE.CNetLayer_EndAddressTranslation(swigCPtr, CExoString.getCPtr(sInternetAddress));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int StartEnumerateSessionsSection(uint nEnumerateSection, uint nSize, CExoString sServerListToEnumerate) {
    int ret = NWNXLibPINVOKE.CNetLayer_StartEnumerateSessionsSection(swigCPtr, nEnumerateSection, nSize, CExoString.getCPtr(sServerListToEnumerate));
    return ret;
  }

  public int GetAnySessionsEnumerated() {
    int ret = NWNXLibPINVOKE.CNetLayer_GetAnySessionsEnumerated(swigCPtr);
    return ret;
  }

  public int EndEnumerateSessionsSection(uint nEnumerateSection) {
    int ret = NWNXLibPINVOKE.CNetLayer_EndEnumerateSessionsSection(swigCPtr, nEnumerateSection);
    return ret;
  }

  public int EndEnumerateSessions() {
    int ret = NWNXLibPINVOKE.CNetLayer_EndEnumerateSessions(swigCPtr);
    return ret;
  }

  public void CleanUpEnumerateSpecific() {
    NWNXLibPINVOKE.CNetLayer_CleanUpEnumerateSpecific(swigCPtr);
  }

  public uint GetSessionSectionStart(uint sectionSectionId) {
    uint ret = NWNXLibPINVOKE.CNetLayer_GetSessionSectionStart(swigCPtr, sectionSectionId);
    return ret;
  }

  public int StartConnectToSession(uint nSessionId, CExoString sPlayerName, int nPlayerLanguage, CExoString sPassword, uint nTimeOut, uint nConnectionType, CExoString sCDKey, CExoString sLegacyCDKey, CExoString expectCryptoPublicKeyBase64) {
    int ret = NWNXLibPINVOKE.CNetLayer_StartConnectToSession__SWIG_0(swigCPtr, nSessionId, CExoString.getCPtr(sPlayerName), nPlayerLanguage, CExoString.getCPtr(sPassword), nTimeOut, nConnectionType, CExoString.getCPtr(sCDKey), CExoString.getCPtr(sLegacyCDKey), CExoString.getCPtr(expectCryptoPublicKeyBase64));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int StartConnectToSession(uint nSessionId, CExoString sPlayerName, int nPlayerLanguage, CExoString sPassword, uint nTimeOut, uint nConnectionType, CExoString sCDKey, CExoString sLegacyCDKey) {
    int ret = NWNXLibPINVOKE.CNetLayer_StartConnectToSession__SWIG_1(swigCPtr, nSessionId, CExoString.getCPtr(sPlayerName), nPlayerLanguage, CExoString.getCPtr(sPassword), nTimeOut, nConnectionType, CExoString.getCPtr(sCDKey), CExoString.getCPtr(sLegacyCDKey));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RequestExtendedServerInfo(uint nSessionId, int bGetInfo, int bGetPing) {
    int ret = NWNXLibPINVOKE.CNetLayer_RequestExtendedServerInfo__SWIG_0(swigCPtr, nSessionId, bGetInfo, bGetPing);
    return ret;
  }

  public int RequestExtendedServerInfo(uint nSessionId, int bGetInfo) {
    int ret = NWNXLibPINVOKE.CNetLayer_RequestExtendedServerInfo__SWIG_1(swigCPtr, nSessionId, bGetInfo);
    return ret;
  }

  public int RequestExtendedServerInfo(uint nSessionId) {
    int ret = NWNXLibPINVOKE.CNetLayer_RequestExtendedServerInfo__SWIG_2(swigCPtr, nSessionId);
    return ret;
  }

  public int RequestServerDetails(uint nConnectionId) {
    int ret = NWNXLibPINVOKE.CNetLayer_RequestServerDetails(swigCPtr, nConnectionId);
    return ret;
  }

  public int StartPing(uint nSessionId) {
    int ret = NWNXLibPINVOKE.CNetLayer_StartPing(swigCPtr, nSessionId);
    return ret;
  }

  public int EndPing(uint nSessionId) {
    int ret = NWNXLibPINVOKE.CNetLayer_EndPing(swigCPtr, nSessionId);
    return ret;
  }

  public int GetNumberLocalAdapters(uint nProtocol) {
    int ret = NWNXLibPINVOKE.CNetLayer_GetNumberLocalAdapters(swigCPtr, nProtocol);
    return ret;
  }

  public CExoString GetLocalAdapterString(uint nProtocol, uint nAdapterNumber) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetLocalAdapterString(swigCPtr, nProtocol, nAdapterNumber), true);
    return ret;
  }

  public void SetSessionInfoChanged(uint nSessionId, int bHasChanged) {
    NWNXLibPINVOKE.CNetLayer_SetSessionInfoChanged(swigCPtr, nSessionId, bHasChanged);
  }

  public int GetSessionInfoChanged(uint nSessionSection) {
    int ret = NWNXLibPINVOKE.CNetLayer_GetSessionInfoChanged(swigCPtr, nSessionSection);
    return ret;
  }

  public void ClearSessionInfoChanged(uint nSessionSection) {
    NWNXLibPINVOKE.CNetLayer_ClearSessionInfoChanged(swigCPtr, nSessionSection);
  }

  public uint GetSessionMaxPlayers() {
    uint ret = NWNXLibPINVOKE.CNetLayer_GetSessionMaxPlayers(swigCPtr);
    return ret;
  }

  public void SetSessionMaxPlayers(uint nMaxPlayers) {
    NWNXLibPINVOKE.CNetLayer_SetSessionMaxPlayers(swigCPtr, nMaxPlayers);
  }

  public CExoString GetSessionName() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetSessionName(swigCPtr), true);
    return ret;
  }

  public void SetSessionName(CExoString sSessionName) {
    NWNXLibPINVOKE.CNetLayer_SetSessionName(swigCPtr, CExoString.getCPtr(sSessionName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetUDPRecievePort() {
    uint ret = NWNXLibPINVOKE.CNetLayer_GetUDPRecievePort(swigCPtr);
    return ret;
  }

  public uint GetPortBySessionId(uint nSessionId) {
    uint ret = NWNXLibPINVOKE.CNetLayer_GetPortBySessionId(swigCPtr, nSessionId);
    return ret;
  }

  public CNetLayerSessionInfo GetSessionInfo(uint nSession) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayer_GetSessionInfo(swigCPtr, nSession);
    CNetLayerSessionInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNetLayerSessionInfo(cPtr, false);
    return ret;
  }

  public int EndConnectToSession() {
    int ret = NWNXLibPINVOKE.CNetLayer_EndConnectToSession(swigCPtr);
    return ret;
  }

  public uint GetConnectionError() {
    uint ret = NWNXLibPINVOKE.CNetLayer_GetConnectionError(swigCPtr);
    return ret;
  }

  public int GetClientConnected() {
    int ret = NWNXLibPINVOKE.CNetLayer_GetClientConnected(swigCPtr);
    return ret;
  }

  public uint GetLocalPrivileges(uint nConnectType) {
    uint ret = NWNXLibPINVOKE.CNetLayer_GetLocalPrivileges(swigCPtr, nConnectType);
    return ret;
  }

  public int DisconnectFromSession() {
    int ret = NWNXLibPINVOKE.CNetLayer_DisconnectFromSession(swigCPtr);
    return ret;
  }

  public int DropConnectionToServer() {
    int ret = NWNXLibPINVOKE.CNetLayer_DropConnectionToServer(swigCPtr);
    return ret;
  }

  public int IsConnectedToLocalhost() {
    int ret = NWNXLibPINVOKE.CNetLayer_IsConnectedToLocalhost(swigCPtr);
    return ret;
  }

  public int MessageArrived(uint nProtocol, uint nSocketId, uint nErrorCode, int bRemoveFromQueue) {
    int ret = NWNXLibPINVOKE.CNetLayer_MessageArrived__SWIG_0(swigCPtr, nProtocol, nSocketId, nErrorCode, bRemoveFromQueue);
    return ret;
  }

  public int MessageArrived(uint nProtocol, uint nSocketId, uint nErrorCode) {
    int ret = NWNXLibPINVOKE.CNetLayer_MessageArrived__SWIG_1(swigCPtr, nProtocol, nSocketId, nErrorCode);
    return ret;
  }

  public void ProcessReceivedFrames(int bProcessReceivedMessage) {
    NWNXLibPINVOKE.CNetLayer_ProcessReceivedFrames__SWIG_0(swigCPtr, bProcessReceivedMessage);
  }

  public void ProcessReceivedFrames() {
    NWNXLibPINVOKE.CNetLayer_ProcessReceivedFrames__SWIG_1(swigCPtr);
  }

  public int SendMessageToPlayer(uint nPlayerId, byte* pData, uint nSize, uint nFlags) {
    int ret = NWNXLibPINVOKE.CNetLayer_SendMessageToPlayer(swigCPtr, nPlayerId, (global::System.IntPtr)pData, nSize, nFlags);
    return ret;
  }

  public int SendMessageToAddress(uint nConnectionId, byte* pData, uint nSize) {
    int ret = NWNXLibPINVOKE.CNetLayer_SendMessageToAddress(swigCPtr, nConnectionId, (global::System.IntPtr)pData, nSize);
    return ret;
  }

  public int UpdateStatusLoop(uint nApplicationType) {
    int ret = NWNXLibPINVOKE.CNetLayer_UpdateStatusLoop(swigCPtr, nApplicationType);
    return ret;
  }

  public int GetPlayerAddressData(uint nConnectionId, uint* nProtocol, byte** pNetAddress1, byte** pNetAddress2, uint* nPort) {
    int ret = NWNXLibPINVOKE.CNetLayer_GetPlayerAddressData(swigCPtr, nConnectionId, (global::System.IntPtr)nProtocol, (global::System.IntPtr)pNetAddress1, (global::System.IntPtr)pNetAddress2, (global::System.IntPtr)nPort);
    return ret;
  }

  public void StoreMessage(byte* pData, uint nMsgLength) {
    NWNXLibPINVOKE.CNetLayer_StoreMessage(swigCPtr, (global::System.IntPtr)pData, nMsgLength);
  }

  public int GetGameMasterPermision() {
    int ret = NWNXLibPINVOKE.CNetLayer_GetGameMasterPermision(swigCPtr);
    return ret;
  }

  public void SetGameMasterPermission(int state) {
    NWNXLibPINVOKE.CNetLayer_SetGameMasterPermission(swigCPtr, state);
  }

  public int TranslateAddressFromString(string szAddress, uint* nProtocol, byte* pNetAddress1, byte* pNetAddress2, uint* nWPort) {
    int ret = NWNXLibPINVOKE.CNetLayer_TranslateAddressFromString(swigCPtr, szAddress, (global::System.IntPtr)nProtocol, (global::System.IntPtr)pNetAddress1, (global::System.IntPtr)pNetAddress2, (global::System.IntPtr)nWPort);
    return ret;
  }

  public SWIGTYPE_p_CExoNet GetExoNet() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayer_GetExoNet(swigCPtr);
    SWIGTYPE_p_CExoNet ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoNet(cPtr, false);
    return ret;
  }

  public CExoString GetServerNetworkAddress() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetServerNetworkAddress(swigCPtr), true);
    return ret;
  }

  public void SetCurrentMasterServerInternetAddress(uint nAddress, uint nPort) {
    NWNXLibPINVOKE.CNetLayer_SetCurrentMasterServerInternetAddress(swigCPtr, nAddress, nPort);
  }

  public uint GetSendUDPSocket() {
    uint ret = NWNXLibPINVOKE.CNetLayer_GetSendUDPSocket(swigCPtr);
    return ret;
  }

  public void ShutDownClientInterfaceWithReason(uint nReason, CExoString sReason) {
    NWNXLibPINVOKE.CNetLayer_ShutDownClientInterfaceWithReason__SWIG_0(swigCPtr, nReason, CExoString.getCPtr(sReason));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ShutDownClientInterfaceWithReason(uint nReason) {
    NWNXLibPINVOKE.CNetLayer_ShutDownClientInterfaceWithReason__SWIG_1(swigCPtr, nReason);
  }

  public void SetMstServerPassword(CExoString szTemp) {
    NWNXLibPINVOKE.CNetLayer_SetMstServerPassword(swigCPtr, CExoString.getCPtr(szTemp));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetExpansionPackReqd(ushort nExpansionPack) {
    NWNXLibPINVOKE.CNetLayer_SetExpansionPackReqd(swigCPtr, nExpansionPack);
  }

  public ushort GetExpansionPackReqd() {
    ushort ret = NWNXLibPINVOKE.CNetLayer_GetExpansionPackReqd(swigCPtr);
    return ret;
  }

  public int PlayerIdToConnectionId(uint nPlayerId, uint* nConnectionId) {
    int ret = NWNXLibPINVOKE.CNetLayer_PlayerIdToConnectionId(swigCPtr, nPlayerId, (global::System.IntPtr)nConnectionId);
    return ret;
  }

  public int GetAnyWindowBehind() {
    int ret = NWNXLibPINVOKE.CNetLayer_GetAnyWindowBehind(swigCPtr);
    return ret;
  }

  public int OpenStandardConnection(int nConnectionToUse, CExoString sHostName, int nPort) {
    int ret = NWNXLibPINVOKE.CNetLayer_OpenStandardConnection(swigCPtr, nConnectionToUse, CExoString.getCPtr(sHostName), nPort);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetMessageFromStandardConnection(int* nConnectionFrom, char** pMessage, int* nSize) {
    int ret = NWNXLibPINVOKE.CNetLayer_GetMessageFromStandardConnection(swigCPtr, (global::System.IntPtr)nConnectionFrom, (global::System.IntPtr)pMessage, (global::System.IntPtr)nSize);
    return ret;
  }

  public int SendMessageToStandardConnection(int nConnectionTo, string pmessage, int nSize) {
    int ret = NWNXLibPINVOKE.CNetLayer_SendMessageToStandardConnection(swigCPtr, nConnectionTo, pmessage, nSize);
    return ret;
  }

  public int CloseStandardConnection(int nConnectonToClose) {
    int ret = NWNXLibPINVOKE.CNetLayer_CloseStandardConnection(swigCPtr, nConnectonToClose);
    return ret;
  }

  public int GetIPBySessionId(uint nSessionId, CExoString sIPAddress) {
    int ret = NWNXLibPINVOKE.CNetLayer_GetIPBySessionId(swigCPtr, nSessionId, CExoString.getCPtr(sIPAddress));
    return ret;
  }

  public void SetConnectionsDisallowed(int bDisallowLoginWhileMasterServerIsDown) {
    NWNXLibPINVOKE.CNetLayer_SetConnectionsDisallowed(swigCPtr, bDisallowLoginWhileMasterServerIsDown);
  }

  public int GetConnectionsMustBeValidated() {
    int ret = NWNXLibPINVOKE.CNetLayer_GetConnectionsMustBeValidated(swigCPtr);
    return ret;
  }

  public void SetConnectionsMustBeValidated(int bValidateLoginWhileMasterServerIsNotResponding) {
    NWNXLibPINVOKE.CNetLayer_SetConnectionsMustBeValidated(swigCPtr, bValidateLoginWhileMasterServerIsNotResponding);
  }

  public int GetEnumerateSpecificOverRelay() {
    int ret = NWNXLibPINVOKE.CNetLayer_GetEnumerateSpecificOverRelay(swigCPtr);
    return ret;
  }

  public void SetEnumerateSpecificOverRelay(int state, string relayToken) {
    NWNXLibPINVOKE.CNetLayer_SetEnumerateSpecificOverRelay(swigCPtr, state, relayToken);
  }

  public CExoString GetRouterPortMapDescription() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNetLayer_GetRouterPortMapDescription(swigCPtr), true);
    return ret;
  }

  public void SetNWSyncData(SWIGTYPE_p_NWSync__Advertisement datra) {
    NWNXLibPINVOKE.CNetLayer_SetNWSyncData(swigCPtr, SWIGTYPE_p_NWSync__Advertisement.getCPtr(datra));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NWSyncAdvertisement GetNWSyncData() {
    NWSyncAdvertisement ret = new NWSyncAdvertisement(NWNXLibPINVOKE.CNetLayer_GetNWSyncData(swigCPtr), false);
    return ret;
  }

  public int ServerSatisfiesBuild(int nBuild, int nRevision) {
    int ret = NWNXLibPINVOKE.CNetLayer_ServerSatisfiesBuild(swigCPtr, nBuild, nRevision);
    return ret;
  }

}

}
