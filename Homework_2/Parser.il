// Type: IL_library_.Parser 
// Assembly: Homework_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7C6432AF-222C-45BE-9C86-AAD0CF94BF2A
// Location: C:\Users\User\Homework-.NET\Homework_1\bin\Debug\net5.0\Homework_1.dll
// Sequence point data from C:\Users\User\Homework-.NET\Homework_1\bin\Debug\net5.0\Homework_1.pdb

.class public auto ansi beforefieldinit
  IL_library_.Parser
    extends [System.Runtime]System.Object
{

  .method public hidebysig static bool
    IsInt(
      string num1,
      [out] int32& num2
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool V_0,
      [1] bool V_1
    )

    // [6 9 - 6 10]
    IL_0000: nop

    // [7 13 - 7 46]
    IL_0001: ldarg.0      // num1
    IL_0002: ldarg.1      // num2
    IL_0003: call         bool [System.Runtime]System.Int32::TryParse(string, int32&)
    IL_0008: stloc.0      // V_0

    IL_0009: ldloc.0      // V_0
    IL_000a: brfalse.s    IL_0010

    // [8 17 - 8 29]
    IL_000c: ldc.i4.1
    IL_000d: stloc.1      // V_1
    IL_000e: br.s         IL_0015

    // [10 13 - 10 14]
    IL_0010: nop

    // [11 17 - 11 30]
    IL_0011: ldc.i4.0
    IL_0012: stloc.1      // V_1
    IL_0013: br.s         IL_0015

    // [13 9 - 13 10]
    IL_0015: ldloc.1      // V_1
    IL_0016: ret

  } // end of method Parser::IsInt

  .method public hidebysig static valuetype IL_library_.Calculator/operations
    OperationDetector(
      string arg
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] valuetype IL_library_.Calculator/operations operation,
      [1] string V_1,
      [2] string V_2,
      [3] valuetype IL_library_.Calculator/operations V_3
    )

    // [16 9 - 16 10]
    IL_0000: nop

    // [18 13 - 18 25]
    IL_0001: ldarg.0      // arg
    IL_0002: stloc.2      // V_2

    IL_0003: ldloc.2      // V_2
    IL_0004: stloc.1      // V_1

    IL_0005: ldloc.1      // V_1
    IL_0006: ldstr        "+"
    IL_000b: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_0010: brtrue.s     IL_003b
    IL_0012: ldloc.1      // V_1
    IL_0013: ldstr        "-"
    IL_0018: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_001d: brtrue.s     IL_003f
    IL_001f: ldloc.1      // V_1
    IL_0020: ldstr        "*"
    IL_0025: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_002a: brtrue.s     IL_0043
    IL_002c: ldloc.1      // V_1
    IL_002d: ldstr        "/"
    IL_0032: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_0037: brtrue.s     IL_0047
    IL_0039: br.s         IL_004b

    // [21 21 - 21 60]
    IL_003b: ldc.i4.0
    IL_003c: stloc.0      // operation

    // [22 21 - 22 27]
    IL_003d: br.s         IL_004f

    // [24 21 - 24 61]
    IL_003f: ldc.i4.1
    IL_0040: stloc.0      // operation

    // [25 21 - 25 27]
    IL_0041: br.s         IL_004f

    // [27 21 - 27 60]
    IL_0043: ldc.i4.2
    IL_0044: stloc.0      // operation

    // [28 21 - 28 27]
    IL_0045: br.s         IL_004f

    // [30 21 - 30 62]
    IL_0047: ldc.i4.3
    IL_0048: stloc.0      // operation

    // [31 21 - 31 27]
    IL_0049: br.s         IL_004f

    // [33 21 - 33 72]
    IL_004b: ldc.i4.4
    IL_004c: stloc.0      // operation

    // [34 21 - 34 27]
    IL_004d: br.s         IL_004f

    // [36 13 - 36 30]
    IL_004f: ldloc.0      // operation
    IL_0050: stloc.3      // V_3
    IL_0051: br.s         IL_0053

    // [37 9 - 37 10]
    IL_0053: ldloc.3      // V_3
    IL_0054: ret

  } // end of method Parser::OperationDetector

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [System.Runtime]System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret

  } // end of method Parser::.ctor
} // end of class IL_library_.Parser
