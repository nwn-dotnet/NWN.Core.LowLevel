//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class CNWSExpression : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSExpression(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSExpression obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSExpression() {
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
          NWNXLibPINVOKE.delete_CNWSExpression(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int m_nExpressionId {
    set {
      NWNXLibPINVOKE.CNWSExpression_m_nExpressionId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSExpression_m_nExpressionId_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_CExoArrayListT_CExoString_p_t m_aStored {
    set {
      NWNXLibPINVOKE.CNWSExpression_m_aStored_set(swigCPtr, SWIGTYPE_p_CExoArrayListT_CExoString_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpression_m_aStored_get(swigCPtr);
      SWIGTYPE_p_CExoArrayListT_CExoString_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoArrayListT_CExoString_p_t(cPtr, false);
      return ret;
    } 
  }

  public int m_bCaseSensitive {
    set {
      NWNXLibPINVOKE.CNWSExpression_m_bCaseSensitive_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSExpression_m_bCaseSensitive_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSExpressionList m_pGraph {
    set {
      NWNXLibPINVOKE.CNWSExpression_m_pGraph_set(swigCPtr, CNWSExpressionList.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpression_m_pGraph_get(swigCPtr);
      CNWSExpressionList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSExpressionList(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sParsedString {
    set {
      NWNXLibPINVOKE.CNWSExpression_m_sParsedString_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpression_m_sParsedString_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CNWSExpression() : this(NWNXLibPINVOKE.new_CNWSExpression(), true) {
  }

  public int ParseString(CExoString sStringToParse) {
    int ret = NWNXLibPINVOKE.CNWSExpression_ParseString(swigCPtr, CExoString.getCPtr(sStringToParse));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int TestString(CExoString sStringToTest, int bFindStrings) {
    int ret = NWNXLibPINVOKE.CNWSExpression_TestString__SWIG_0(swigCPtr, CExoString.getCPtr(sStringToTest), bFindStrings);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int TestString(CExoString sStringToTest) {
    int ret = NWNXLibPINVOKE.CNWSExpression_TestString__SWIG_1(swigCPtr, CExoString.getCPtr(sStringToTest));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ClearGraph() {
    NWNXLibPINVOKE.CNWSExpression_ClearGraph(swigCPtr);
  }

  public void ClearAlternate(CNWSExpressionNode pNode) {
    NWNXLibPINVOKE.CNWSExpression_ClearAlternate(swigCPtr, CNWSExpressionNode.getCPtr(pNode));
  }

  public CNWSExpressionNode NewNode(int nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpression_NewNode(swigCPtr, nType);
    CNWSExpressionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSExpressionNode(cPtr, false);
    return ret;
  }

}

}