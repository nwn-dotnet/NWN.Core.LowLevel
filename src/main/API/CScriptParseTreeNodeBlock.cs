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

public unsafe class CScriptParseTreeNodeBlock : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CScriptParseTreeNodeBlock(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CScriptParseTreeNodeBlock(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptParseTreeNodeBlock obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptParseTreeNodeBlock() {
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
          NWNXLibPINVOKE.delete_CScriptParseTreeNodeBlock(swigCPtr);
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

  public static unsafe implicit operator void*(CScriptParseTreeNodeBlock self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CScriptParseTreeNodeBlock self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CScriptParseTreeNodeBlock other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CScriptParseTreeNodeBlock other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CScriptParseTreeNodeBlock left, CScriptParseTreeNodeBlock right) {
    return Equals(left, right);
  }

  public static bool operator !=(CScriptParseTreeNodeBlock left, CScriptParseTreeNodeBlock right) {
    return !Equals(left, right);
  }

  public CScriptParseTreeNodeArray m_pNodes {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNodeBlock_m_pNodes_set(swigCPtr, CScriptParseTreeNodeArray.getCPtr(value));
    }  
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptParseTreeNodeBlock_m_pNodes_get(swigCPtr);;
        CScriptParseTreeNodeArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptParseTreeNodeArray(cPtr, false);
        return ret;
    }

  }

  public CScriptParseTreeNodeBlock m_pNextBlock {
    set {
      NWNXLibPINVOKE.CScriptParseTreeNodeBlock_m_pNextBlock_set(swigCPtr, CScriptParseTreeNodeBlock.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptParseTreeNodeBlock_m_pNextBlock_get(swigCPtr);
      CScriptParseTreeNodeBlock ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptParseTreeNodeBlock(cPtr, false);
      return ret;
    } 
  }

  public CScriptParseTreeNodeBlock() : this(NWNXLibPINVOKE.new_CScriptParseTreeNodeBlock(), true) {
  }

}

}
