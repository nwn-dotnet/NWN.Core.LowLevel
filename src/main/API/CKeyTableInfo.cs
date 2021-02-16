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

public unsafe class CKeyTableInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CKeyTableInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CKeyTableInfo(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CKeyTableInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CKeyTableInfo() {
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
          NWNXLibPINVOKE.delete_CKeyTableInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CKeyTableInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CKeyTableInfo self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CKeyTableInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CKeyTableInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CKeyTableInfo left, CKeyTableInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CKeyTableInfo left, CKeyTableInfo right) {
    return !Equals(left, right);
  }

  public CExoString m_sName {
    set {
      NWNXLibPINVOKE.CKeyTableInfo_m_sName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CKeyTableInfo_m_sName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoFile m_pFile {
    set {
      NWNXLibPINVOKE.CKeyTableInfo_m_pFile_set(swigCPtr, CExoFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CKeyTableInfo_m_pFile_get(swigCPtr);
      CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
      return ret;
    } 
  }

  public KEYFILE_HEADER m_header {
    set {
      NWNXLibPINVOKE.CKeyTableInfo_m_header_set(swigCPtr, KEYFILE_HEADER.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CKeyTableInfo_m_header_get(swigCPtr);
      KEYFILE_HEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new KEYFILE_HEADER(cPtr, false);
      return ret;
    } 
  }

  public KEYFILE_RESFILENAME m_pResFileNames {
    set {
      NWNXLibPINVOKE.CKeyTableInfo_m_pResFileNames_set(swigCPtr, KEYFILE_RESFILENAME.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CKeyTableInfo_m_pResFileNames_get(swigCPtr);
      KEYFILE_RESFILENAME ret = (cPtr == global::System.IntPtr.Zero) ? null : new KEYFILE_RESFILENAME(cPtr, false);
      return ret;
    } 
  }

  public CKeyTableInfo() : this(NWNXLibPINVOKE.new_CKeyTableInfo(), true) {
  }

}

}
