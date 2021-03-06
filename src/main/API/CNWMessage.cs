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

public unsafe class CNWMessage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWMessage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWMessage(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWMessage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWMessage() {
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
          NWNXLibPINVOKE.delete_CNWMessage(swigCPtr);
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

  public static unsafe implicit operator void*(CNWMessage self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWMessage self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWMessage other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWMessage other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWMessage left, CNWMessage right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWMessage left, CNWMessage right) {
    return !Equals(left, right);
  }

  public byte* m_pnWriteBuffer {
    set {
      NWNXLibPINVOKE.CNWMessage_m_pnWriteBuffer_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWMessage_m_pnWriteBuffer_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public uint m_nWriteBufferSize {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nWriteBufferSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nWriteBufferSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nWriteBufferPtr {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nWriteBufferPtr_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nWriteBufferPtr_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pnWriteFragmentsBuffer {
    set {
      NWNXLibPINVOKE.CNWMessage_m_pnWriteFragmentsBuffer_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWMessage_m_pnWriteFragmentsBuffer_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public uint m_nWriteFragmentsBufferSize {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nWriteFragmentsBufferSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nWriteFragmentsBufferSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nWriteFragmentsBufferPtr {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nWriteFragmentsBufferPtr_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nWriteFragmentsBufferPtr_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nWriteFragmentsOffset {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nWriteFragmentsOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nWriteFragmentsOffset_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCurWriteBit {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nCurWriteBit_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWMessage_m_nCurWriteBit_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bInWriteMessage {
    set {
      NWNXLibPINVOKE.CNWMessage_m_bInWriteMessage_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWMessage_m_bInWriteMessage_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pnReadBuffer {
    set {
      NWNXLibPINVOKE.CNWMessage_m_pnReadBuffer_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWMessage_m_pnReadBuffer_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public uint m_nReadBufferSize {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nReadBufferSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nReadBufferSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nReadBufferPtr {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nReadBufferPtr_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nReadBufferPtr_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pnReadFragmentsBuffer {
    set {
      NWNXLibPINVOKE.CNWMessage_m_pnReadFragmentsBuffer_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWMessage_m_pnReadFragmentsBuffer_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public uint m_nReadFragmentsBufferSize {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nReadFragmentsBufferSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nReadFragmentsBufferSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nReadFragmentsBufferPtr {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nReadFragmentsBufferPtr_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nReadFragmentsBufferPtr_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nReadFragmentsOffset {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nReadFragmentsOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_nReadFragmentsOffset_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCurReadBit {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nCurReadBit_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWMessage_m_nCurReadBit_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nLastByteBits {
    set {
      NWNXLibPINVOKE.CNWMessage_m_nLastByteBits_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWMessage_m_nLastByteBits_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHighPriority {
    set {
      NWNXLibPINVOKE.CNWMessage_m_bHighPriority_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWMessage_m_bHighPriority_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_dwPlayerID {
    set {
      NWNXLibPINVOKE.CNWMessage_m_dwPlayerID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWMessage_m_dwPlayerID_get(swigCPtr);
      return ret;
    } 
  }

  public CNWMessage() : this(NWNXLibPINVOKE.new_CNWMessage(), true) {
  }

  public int SetReadMessage(byte* pMessage, uint dwSize, uint dwPlayerID, int bHighPriority) {
    int ret = NWNXLibPINVOKE.CNWMessage_SetReadMessage__SWIG_0(swigCPtr, (global::System.IntPtr)pMessage, dwSize, dwPlayerID, bHighPriority);
    return ret;
  }

  public int SetReadMessage(byte* pMessage, uint dwSize, uint dwPlayerID) {
    int ret = NWNXLibPINVOKE.CNWMessage_SetReadMessage__SWIG_1(swigCPtr, (global::System.IntPtr)pMessage, dwSize, dwPlayerID);
    return ret;
  }

  public int SetReadMessage(byte* pMessage, uint dwSize) {
    int ret = NWNXLibPINVOKE.CNWMessage_SetReadMessage__SWIG_2(swigCPtr, (global::System.IntPtr)pMessage, dwSize);
    return ret;
  }

  public void ClearReadMessage() {
    NWNXLibPINVOKE.CNWMessage_ClearReadMessage(swigCPtr);
  }

  public int ReadBOOL() {
    int ret = NWNXLibPINVOKE.CNWMessage_ReadBOOL(swigCPtr);
    return ret;
  }

  public byte ReadBYTE(int nCount) {
    byte ret = NWNXLibPINVOKE.CNWMessage_ReadBYTE__SWIG_0(swigCPtr, nCount);
    return ret;
  }

  public byte ReadBYTE() {
    byte ret = NWNXLibPINVOKE.CNWMessage_ReadBYTE__SWIG_1(swigCPtr);
    return ret;
  }

  public char ReadCHAR(int nCount) {
    char ret = NWNXLibPINVOKE.CNWMessage_ReadCHAR__SWIG_0(swigCPtr, nCount);
    return ret;
  }

  public char ReadCHAR() {
    char ret = NWNXLibPINVOKE.CNWMessage_ReadCHAR__SWIG_1(swigCPtr);
    return ret;
  }

  public ushort ReadWORD(int nCount) {
    ushort ret = NWNXLibPINVOKE.CNWMessage_ReadWORD__SWIG_0(swigCPtr, nCount);
    return ret;
  }

  public ushort ReadWORD() {
    ushort ret = NWNXLibPINVOKE.CNWMessage_ReadWORD__SWIG_1(swigCPtr);
    return ret;
  }

  public short ReadSHORT(int nCount) {
    short ret = NWNXLibPINVOKE.CNWMessage_ReadSHORT__SWIG_0(swigCPtr, nCount);
    return ret;
  }

  public short ReadSHORT() {
    short ret = NWNXLibPINVOKE.CNWMessage_ReadSHORT__SWIG_1(swigCPtr);
    return ret;
  }

  public uint ReadDWORD(int nCount) {
    uint ret = NWNXLibPINVOKE.CNWMessage_ReadDWORD__SWIG_0(swigCPtr, nCount);
    return ret;
  }

  public uint ReadDWORD() {
    uint ret = NWNXLibPINVOKE.CNWMessage_ReadDWORD__SWIG_1(swigCPtr);
    return ret;
  }

  public int ReadINT(int nCount) {
    int ret = NWNXLibPINVOKE.CNWMessage_ReadINT__SWIG_0(swigCPtr, nCount);
    return ret;
  }

  public int ReadINT() {
    int ret = NWNXLibPINVOKE.CNWMessage_ReadINT__SWIG_1(swigCPtr);
    return ret;
  }

  public uint ReadDWORD64(int nCount) {
    uint ret = NWNXLibPINVOKE.CNWMessage_ReadDWORD64__SWIG_0(swigCPtr, nCount);
    return ret;
  }

  public uint ReadDWORD64() {
    uint ret = NWNXLibPINVOKE.CNWMessage_ReadDWORD64__SWIG_1(swigCPtr);
    return ret;
  }

  public int ReadINT64(int nCount) {
    int ret = NWNXLibPINVOKE.CNWMessage_ReadINT64__SWIG_0(swigCPtr, nCount);
    return ret;
  }

  public int ReadINT64() {
    int ret = NWNXLibPINVOKE.CNWMessage_ReadINT64__SWIG_1(swigCPtr);
    return ret;
  }

  public float ReadFLOAT(float fMultiplier, int nCount) {
    float ret = NWNXLibPINVOKE.CNWMessage_ReadFLOAT__SWIG_0(swigCPtr, fMultiplier, nCount);
    return ret;
  }

  public float ReadFLOAT(float fMultiplier) {
    float ret = NWNXLibPINVOKE.CNWMessage_ReadFLOAT__SWIG_1(swigCPtr, fMultiplier);
    return ret;
  }

  public float ReadFLOAT() {
    float ret = NWNXLibPINVOKE.CNWMessage_ReadFLOAT__SWIG_2(swigCPtr);
    return ret;
  }

  public float ReadFLOAT(float fMin, float fMax, int nCount) {
    float ret = NWNXLibPINVOKE.CNWMessage_ReadFLOAT__SWIG_3(swigCPtr, fMin, fMax, nCount);
    return ret;
  }

  public double ReadDOUBLE(double fMultiplier, int nCount) {
    double ret = NWNXLibPINVOKE.CNWMessage_ReadDOUBLE__SWIG_0(swigCPtr, fMultiplier, nCount);
    return ret;
  }

  public double ReadDOUBLE(double fMultiplier) {
    double ret = NWNXLibPINVOKE.CNWMessage_ReadDOUBLE__SWIG_1(swigCPtr, fMultiplier);
    return ret;
  }

  public double ReadDOUBLE() {
    double ret = NWNXLibPINVOKE.CNWMessage_ReadDOUBLE__SWIG_2(swigCPtr);
    return ret;
  }

  public double ReadDOUBLE(double lfMin, double lfMax, int nCount) {
    double ret = NWNXLibPINVOKE.CNWMessage_ReadDOUBLE__SWIG_3(swigCPtr, lfMin, lfMax, nCount);
    return ret;
  }

  public CResRef ReadCResRef(int nCount) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWMessage_ReadCResRef__SWIG_0(swigCPtr, nCount), true);
    return ret;
  }

  public CResRef ReadCResRef() {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWMessage_ReadCResRef__SWIG_1(swigCPtr), true);
    return ret;
  }

  public CExoString ReadCExoString(int nCount) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWMessage_ReadCExoString__SWIG_0(swigCPtr, nCount), true);
    return ret;
  }

  public CExoString ReadCExoString() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWMessage_ReadCExoString__SWIG_1(swigCPtr), true);
    return ret;
  }

  public void* ReadVOIDPtr(int nSize) { 
    System.IntPtr retVal = NWNXLibPINVOKE.CNWMessage_ReadVOIDPtr(swigCPtr, nSize);
    return (void*)retVal;
  }

  public int MessageReadOverflow(int bWarn) {
    int ret = NWNXLibPINVOKE.CNWMessage_MessageReadOverflow__SWIG_0(swigCPtr, bWarn);
    return ret;
  }

  public int MessageReadOverflow() {
    int ret = NWNXLibPINVOKE.CNWMessage_MessageReadOverflow__SWIG_1(swigCPtr);
    return ret;
  }

  public int MessageReadUnderflow(int bWarn) {
    int ret = NWNXLibPINVOKE.CNWMessage_MessageReadUnderflow__SWIG_0(swigCPtr, bWarn);
    return ret;
  }

  public int MessageReadUnderflow() {
    int ret = NWNXLibPINVOKE.CNWMessage_MessageReadUnderflow__SWIG_1(swigCPtr);
    return ret;
  }

  public int MessageMoreDataToRead() {
    int ret = NWNXLibPINVOKE.CNWMessage_MessageMoreDataToRead(swigCPtr);
    return ret;
  }

  public void CreateWriteMessage(uint nSize, uint dwPlayerID, int bHighPriority) {
    NWNXLibPINVOKE.CNWMessage_CreateWriteMessage__SWIG_0(swigCPtr, nSize, dwPlayerID, bHighPriority);
  }

  public void CreateWriteMessage(uint nSize, uint dwPlayerID) {
    NWNXLibPINVOKE.CNWMessage_CreateWriteMessage__SWIG_1(swigCPtr, nSize, dwPlayerID);
  }

  public void CreateWriteMessage(uint nSize) {
    NWNXLibPINVOKE.CNWMessage_CreateWriteMessage__SWIG_2(swigCPtr, nSize);
  }

  public void CreateWriteMessage() {
    NWNXLibPINVOKE.CNWMessage_CreateWriteMessage__SWIG_3(swigCPtr);
  }

  public void WriteBOOL(int nBool) {
    NWNXLibPINVOKE.CNWMessage_WriteBOOL(swigCPtr, nBool);
  }

  public void WriteBYTE(byte nByte, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteBYTE__SWIG_0(swigCPtr, nByte, nCount);
  }

  public void WriteBYTE(byte nByte) {
    NWNXLibPINVOKE.CNWMessage_WriteBYTE__SWIG_1(swigCPtr, nByte);
  }

  public void WriteCHAR(char nChar, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteCHAR__SWIG_0(swigCPtr, nChar, nCount);
  }

  public void WriteCHAR(char nChar) {
    NWNXLibPINVOKE.CNWMessage_WriteCHAR__SWIG_1(swigCPtr, nChar);
  }

  public void WriteWORD(ushort nWord, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteWORD__SWIG_0(swigCPtr, nWord, nCount);
  }

  public void WriteWORD(ushort nWord) {
    NWNXLibPINVOKE.CNWMessage_WriteWORD__SWIG_1(swigCPtr, nWord);
  }

  public void WriteSHORT(short nShort, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteSHORT__SWIG_0(swigCPtr, nShort, nCount);
  }

  public void WriteSHORT(short nShort) {
    NWNXLibPINVOKE.CNWMessage_WriteSHORT__SWIG_1(swigCPtr, nShort);
  }

  public void WriteDWORD(uint nDword, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteDWORD__SWIG_0(swigCPtr, nDword, nCount);
  }

  public void WriteDWORD(uint nDword) {
    NWNXLibPINVOKE.CNWMessage_WriteDWORD__SWIG_1(swigCPtr, nDword);
  }

  public void WriteINT(int nInteger, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteINT__SWIG_0(swigCPtr, nInteger, nCount);
  }

  public void WriteINT(int nInteger) {
    NWNXLibPINVOKE.CNWMessage_WriteINT__SWIG_1(swigCPtr, nInteger);
  }

  public void WriteDWORD64(uint nDword64, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteDWORD64__SWIG_0(swigCPtr, nDword64, nCount);
  }

  public void WriteDWORD64(uint nDword64) {
    NWNXLibPINVOKE.CNWMessage_WriteDWORD64__SWIG_1(swigCPtr, nDword64);
  }

  public void WriteINT64(int nInt64, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteINT64__SWIG_0(swigCPtr, nInt64, nCount);
  }

  public void WriteINT64(int nInt64) {
    NWNXLibPINVOKE.CNWMessage_WriteINT64__SWIG_1(swigCPtr, nInt64);
  }

  public void WriteFLOAT(float fFloat, float fMultiplier, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteFLOAT__SWIG_0(swigCPtr, fFloat, fMultiplier, nCount);
  }

  public void WriteFLOAT(float fFloat, float fMultiplier) {
    NWNXLibPINVOKE.CNWMessage_WriteFLOAT__SWIG_1(swigCPtr, fFloat, fMultiplier);
  }

  public void WriteFLOAT(float fFloat) {
    NWNXLibPINVOKE.CNWMessage_WriteFLOAT__SWIG_2(swigCPtr, fFloat);
  }

  public void WriteFLOAT(float fFloat, float fMin, float fMax, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteFLOAT__SWIG_3(swigCPtr, fFloat, fMin, fMax, nCount);
  }

  public void WriteDOUBLE(double fDouble, double fMultiplier, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteDOUBLE__SWIG_0(swigCPtr, fDouble, fMultiplier, nCount);
  }

  public void WriteDOUBLE(double fDouble, double fMultiplier) {
    NWNXLibPINVOKE.CNWMessage_WriteDOUBLE__SWIG_1(swigCPtr, fDouble, fMultiplier);
  }

  public void WriteDOUBLE(double fDouble) {
    NWNXLibPINVOKE.CNWMessage_WriteDOUBLE__SWIG_2(swigCPtr, fDouble);
  }

  public void WriteDOUBLE(double lfDouble, double lfMin, double lfMax, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteDOUBLE__SWIG_3(swigCPtr, lfDouble, lfMin, lfMax, nCount);
  }

  public void WriteCResRef(CResRef cResRef, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteCResRef__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), nCount);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteCResRef(CResRef cResRef) {
    NWNXLibPINVOKE.CNWMessage_WriteCResRef__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteCExoString(CExoString sString, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteCExoString__SWIG_0(swigCPtr, CExoString.getCPtr(sString), nCount);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteCExoString(CExoString sString) {
    NWNXLibPINVOKE.CNWMessage_WriteCExoString__SWIG_1(swigCPtr, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteVOIDPtr(void* pVoidPtr, int nSize) {
    NWNXLibPINVOKE.CNWMessage_WriteVOIDPtr(swigCPtr, (global::System.IntPtr)pVoidPtr, nSize);
  }

  public uint PeekAtWriteMessageSize() {
    uint ret = NWNXLibPINVOKE.CNWMessage_PeekAtWriteMessageSize(swigCPtr);
    return ret;
  }

  public int GetWriteMessage(byte** pMessage, uint* dwSize) {
    int ret = NWNXLibPINVOKE.CNWMessage_GetWriteMessage(swigCPtr, (global::System.IntPtr)pMessage, (global::System.IntPtr)dwSize);
    return ret;
  }

  public void ExtendWriteBuffer(uint nSize) {
    NWNXLibPINVOKE.CNWMessage_ExtendWriteBuffer(swigCPtr, nSize);
  }

  public void ExtendWriteFragmentsBuffer(uint nSize) {
    NWNXLibPINVOKE.CNWMessage_ExtendWriteFragmentsBuffer(swigCPtr, nSize);
  }

  public int ReadBits(int nCount) {
    int ret = NWNXLibPINVOKE.CNWMessage_ReadBits(swigCPtr, nCount);
    return ret;
  }

  public byte ReadBit(byte nBit) {
    byte ret = NWNXLibPINVOKE.CNWMessage_ReadBit(swigCPtr, nBit);
    return ret;
  }

  public void WriteBits(uint nInVal, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteBits(swigCPtr, nInVal, nCount);
  }

  public void WriteBit(byte nBit) {
    NWNXLibPINVOKE.CNWMessage_WriteBit(swigCPtr, nBit);
  }

  public uint ReadUnsigned(int nCount) {
    uint ret = NWNXLibPINVOKE.CNWMessage_ReadUnsigned(swigCPtr, nCount);
    return ret;
  }

  public int ReadSigned(int nCount) {
    int ret = NWNXLibPINVOKE.CNWMessage_ReadSigned(swigCPtr, nCount);
    return ret;
  }

  public void WriteUnsigned(uint dw64InVal, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteUnsigned(swigCPtr, dw64InVal, nCount);
  }

  public void WriteSigned(int n64InVal, int nCount) {
    NWNXLibPINVOKE.CNWMessage_WriteSigned(swigCPtr, n64InVal, nCount);
  }

}

}
