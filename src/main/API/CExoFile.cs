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

public unsafe class CExoFile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoFile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoFile(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoFile() {
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
          NWNXLibPINVOKE.delete_CExoFile(swigCPtr);
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

  public static unsafe implicit operator void*(CExoFile self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CExoFile self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoFile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoFile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoFile left, CExoFile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoFile left, CExoFile right) {
    return !Equals(left, right);
  }

  public SWIGTYPE_p_CExoFileInternal m_pcExoFileInternal {
    set {
      NWNXLibPINVOKE.CExoFile_m_pcExoFileInternal_set(swigCPtr, SWIGTYPE_p_CExoFileInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoFile_m_pcExoFileInternal_get(swigCPtr);
      SWIGTYPE_p_CExoFileInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoFileInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoFile(CExoString fileName, CExoString mode) : this(NWNXLibPINVOKE.new_CExoFile__SWIG_0(CExoString.getCPtr(fileName), CExoString.getCPtr(mode)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoFile(CExoString fileName, ushort fileType, CExoString mode) : this(NWNXLibPINVOKE.new_CExoFile__SWIG_1(CExoString.getCPtr(fileName), fileType, CExoString.getCPtr(mode)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoFile(void* pBuffer, int nSize) : this(NWNXLibPINVOKE.new_CExoFile__SWIG_2((global::System.IntPtr)pBuffer, nSize), true) {
  }

  public void SetMemoryBuffer(void* pMemoryBuffer, int nSize) {
    NWNXLibPINVOKE.CExoFile_SetMemoryBuffer(swigCPtr, (global::System.IntPtr)pMemoryBuffer, nSize);
  }

  public int IsMemoryBacked() {
    int ret = NWNXLibPINVOKE.CExoFile_IsMemoryBacked(swigCPtr);
    return ret;
  }

  public int Eof() {
    int ret = NWNXLibPINVOKE.CExoFile_Eof(swigCPtr);
    return ret;
  }

  public int FileOpened() {
    int ret = NWNXLibPINVOKE.CExoFile_FileOpened(swigCPtr);
    return ret;
  }

  public int Flush() {
    int ret = NWNXLibPINVOKE.CExoFile_Flush(swigCPtr);
    return ret;
  }

  public uint GetOffset() {
    uint ret = NWNXLibPINVOKE.CExoFile_GetOffset(swigCPtr);
    return ret;
  }

  public int GetSize() {
    int ret = NWNXLibPINVOKE.CExoFile_GetSize(swigCPtr);
    return ret;
  }

  public uint Read(void* ptr, uint size, uint number) {
    uint ret = NWNXLibPINVOKE.CExoFile_Read__SWIG_0(swigCPtr, (global::System.IntPtr)ptr, size, number);
    return ret;
  }

  public uint Read(CExoString string_, uint length) {
    uint ret = NWNXLibPINVOKE.CExoFile_Read__SWIG_1(swigCPtr, CExoString.getCPtr(string_), length);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ReadAsync(void* ptr, uint size, uint number) {
    NWNXLibPINVOKE.CExoFile_ReadAsync(swigCPtr, (global::System.IntPtr)ptr, size, number);
  }

  public int ReadAsyncComplete() {
    int ret = NWNXLibPINVOKE.CExoFile_ReadAsyncComplete(swigCPtr);
    return ret;
  }

  public uint ReadAsyncBytesRead() {
    uint ret = NWNXLibPINVOKE.CExoFile_ReadAsyncBytesRead(swigCPtr);
    return ret;
  }

  public uint Write(void* ptr, uint size, uint number) {
    uint ret = NWNXLibPINVOKE.CExoFile_Write__SWIG_0(swigCPtr, (global::System.IntPtr)ptr, size, number);
    return ret;
  }

  public uint Write(string string_) {
    uint ret = NWNXLibPINVOKE.CExoFile_Write__SWIG_1(swigCPtr, string_);
    return ret;
  }

  public uint Write(CExoString string_) {
    uint ret = NWNXLibPINVOKE.CExoFile_Write__SWIG_2(swigCPtr, CExoString.getCPtr(string_));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Seek(int offset, int whence) {
    int ret = NWNXLibPINVOKE.CExoFile_Seek(swigCPtr, offset, whence);
    return ret;
  }

  public int SeekBeginning() {
    int ret = NWNXLibPINVOKE.CExoFile_SeekBeginning(swigCPtr);
    return ret;
  }

  public int SeekEnd() {
    int ret = NWNXLibPINVOKE.CExoFile_SeekEnd(swigCPtr);
    return ret;
  }

  public int IsMMapped() {
    int ret = NWNXLibPINVOKE.CExoFile_IsMMapped(swigCPtr);
    return ret;
  }

  public int GetIsEOS() {
    int ret = NWNXLibPINVOKE.CExoFile_GetIsEOS(swigCPtr);
    return ret;
  }

  public void* GetFileHandle() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoFile_GetFileHandle(swigCPtr);
    return (void*)retVal;
  }

}

}
