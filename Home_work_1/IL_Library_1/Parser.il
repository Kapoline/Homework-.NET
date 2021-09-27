// Type: IL_Library_1.Parser 
// Assembly: IL_Library_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 36E19BD9-0EE3-4CF4-8048-2744423B3925
// Location: C:\Users\User\Homework-.NET\IL_Library_1\bin\Release\IL_Library_1.exe
// Sequence point data from C:\Users\User\Homework-.NET\IL_Library_1\bin\Release\IL_Library_1.pdb
.assembly IL_Library_1
{
.ver 1:0:0:0
}

.class public auto ansi beforefieldinit
  IL_Library_1.Parser
    extends [mscorlib]System.Object
{

  .method public hidebysig static bool
    IsInt(
      string num1,
      [out] int32& num11
    ) cil managed
  {
    .maxstack 8

    // [7 13 - 7 47]
    IL_0000: ldarg.0      // num1
    IL_0001: ldarg.1      // num11
    IL_0002: call         bool [mscorlib]System.Int32::TryParse(string, int32&)
    IL_0007: brfalse.s    IL_000b

    // [8 17 - 8 29]
    IL_0009: ldc.i4.1
    IL_000a: ret

    // [11 17 - 11 30]
    IL_000b: ldc.i4.0
    IL_000c: ret

  } // end of method Parser::IsInt

  .method public hidebysig static valuetype IL_Library_1.Calculator/operations
    OperationDetector(
      string arg
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] valuetype IL_Library_1.Calculator/operations operation
    )

    IL_0000: ldarg.0      // arg
    IL_0001: ldstr        "+"
    IL_0006: call         bool [mscorlib]System.String::op_Equality(string, string)
    IL_000b: brtrue.s     IL_0036
    IL_000d: ldarg.0      // arg
    IL_000e: ldstr        "-"
    IL_0013: call         bool [mscorlib]System.String::op_Equality(string, string)
    IL_0018: brtrue.s     IL_003a
    IL_001a: ldarg.0      // arg
    IL_001b: ldstr        "*"
    IL_0020: call         bool [mscorlib]System.String::op_Equality(string, string)
    IL_0025: brtrue.s     IL_003e
    IL_0027: ldarg.0      // arg
    IL_0028: ldstr        "/"
    IL_002d: call         bool [mscorlib]System.String::op_Equality(string, string)
    IL_0032: brtrue.s     IL_0042
    IL_0034: br.s         IL_0046

    // [21 21 - 21 60]
    IL_0036: ldc.i4.0
    IL_0037: stloc.0      // operation

    // [22 21 - 22 27]
    IL_0038: br.s         IL_0048

    // [24 21 - 24 61]
    IL_003a: ldc.i4.1
    IL_003b: stloc.0      // operation

    // [25 21 - 25 27]
    IL_003c: br.s         IL_0048

    // [27 21 - 27 60]
    IL_003e: ldc.i4.2
    IL_003f: stloc.0      // operation

    // [28 21 - 28 27]
    IL_0040: br.s         IL_0048

    // [30 21 - 30 62]
    IL_0042: ldc.i4.3
    IL_0043: stloc.0      // operation

    // [31 21 - 31 27]
    IL_0044: br.s         IL_0048

    // [33 21 - 33 72]
    IL_0046: ldc.i4.4
    IL_0047: stloc.0      // operation

    // [36 13 - 36 30]
    IL_0048: ldloc.0      // operation
    IL_0049: ret

  } // end of method Parser::OperationDetector

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [mscorlib]System.Object::.ctor()
    IL_0006: ret

  } // end of method Parser::.ctor
} // end of class IL_Library_1.Parser
