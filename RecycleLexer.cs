//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Recycle.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public partial class RecycleLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, T__49=50, T__50=51, T__51=52, 
		T__52=53, BOOLOP=54, COMPOP=55, EQOP=56, UNOP=57, INTNUM=58, OPEN=59, 
		CLOSE=60, WS=61, ANY=62;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "T__48", 
		"T__49", "T__50", "T__51", "T__52", "BOOLOP", "COMPOP", "EQOP", "UNOP", 
		"INTNUM", "OPEN", "CLOSE", "WS", "ANY"
	};


	public RecycleLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'game'", "'setup'", "'stage'", "'player'", "'team'", "'scoring'", 
		"'min'", "'max'", "'end'", "'comp'", "'choice'", "'create'", "'players'", 
		"'teams'", "'deck'", "'permdeck'", "','", "'initialize'", "'points'", 
		"'cycle'", "'next'", "'current'", "'previous'", "'set'", "'inc'", "'dec'", 
		"'move'", "'all'", "'remember'", "'forget'", "'shuffle'", "'turn'", "'pass'", 
		"'top'", "'bottom'", "'any'", "'owner'", "'sto'", "'loc'", "'mem'", "'where'", 
		"'cardatt'", "'each'", "'+'", "'*'", "'-'", "'%'", "'//'", "'size'", "'using'", 
		"'union'", "'sum'", "'score'", null, null, null, "'not'", null, "'('", 
		"')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, "BOOLOP", "COMPOP", "EQOP", "UNOP", 
		"INTNUM", "OPEN", "CLOSE", "WS", "ANY"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Recycle.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2@\x1C7\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37"+
		"\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x4?\t?\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\v\x3"+
		"\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3"+
		"\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF"+
		"\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12"+
		"\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13"+
		"\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15"+
		"\x3\x15\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17"+
		"\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18"+
		"\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19"+
		"\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C"+
		"\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E"+
		"\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3\x1F"+
		"\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3!\x3!"+
		"\x3!\x3\"\x3\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\x3$\x3$"+
		"\x3$\x3%\x3%\x3%\x3%\x3&\x3&\x3&\x3&\x3&\x3&\x3\'\x3\'\x3\'\x3\'\x3(\x3"+
		"(\x3(\x3(\x3)\x3)\x3)\x3)\x3*\x3*\x3*\x3*\x3*\x3*\x3+\x3+\x3+\x3+\x3+"+
		"\x3+\x3+\x3+\x3,\x3,\x3,\x3,\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30\x3\x30"+
		"\x3\x31\x3\x31\x3\x31\x3\x32\x3\x32\x3\x32\x3\x32\x3\x32\x3\x33\x3\x33"+
		"\x3\x33\x3\x33\x3\x33\x3\x33\x3\x34\x3\x34\x3\x34\x3\x34\x3\x34\x3\x34"+
		"\x3\x35\x3\x35\x3\x35\x3\x35\x3\x36\x3\x36\x3\x36\x3\x36\x3\x36\x3\x36"+
		"\x3\x37\x3\x37\x3\x37\x3\x37\x3\x37\x5\x37\x1A6\n\x37\x3\x38\x3\x38\x3"+
		"\x38\x3\x38\x3\x38\x5\x38\x1AD\n\x38\x3\x39\x3\x39\x3\x39\x3\x39\x5\x39"+
		"\x1B3\n\x39\x3:\x3:\x3:\x3:\x3;\x3;\x3<\x3<\x3=\x3=\x3>\x6>\x1C0\n>\r"+
		">\xE>\x1C1\x3>\x3>\x3?\x3?\x2\x2@\x3\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11"+
		"\n\x13\v\x15\f\x17\r\x19\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15"+
		")\x16+\x17-\x18/\x19\x31\x1A\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F= ?!"+
		"\x41\"\x43#\x45$G%I&K\'M(O)Q*S+U,W-Y.[/]\x30_\x31\x61\x32\x63\x33\x65"+
		"\x34g\x35i\x36k\x37m\x38o\x39q:s;u<w=y>{?}@\x3\x2\x5\x4\x2>>@@\x3\x2\x32"+
		";\x5\x2\v\f\xF\xF\"\"\x1CB\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3"+
		"\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3"+
		"\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2"+
		"\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2"+
		"\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2"+
		"\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/"+
		"\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2"+
		"\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2"+
		"\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2"+
		"\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2"+
		"O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2"+
		"\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2"+
		"\x2\x61\x3\x2\x2\x2\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x2g\x3\x2\x2"+
		"\x2\x2i\x3\x2\x2\x2\x2k\x3\x2\x2\x2\x2m\x3\x2\x2\x2\x2o\x3\x2\x2\x2\x2"+
		"q\x3\x2\x2\x2\x2s\x3\x2\x2\x2\x2u\x3\x2\x2\x2\x2w\x3\x2\x2\x2\x2y\x3\x2"+
		"\x2\x2\x2{\x3\x2\x2\x2\x2}\x3\x2\x2\x2\x3\x7F\x3\x2\x2\x2\x5\x84\x3\x2"+
		"\x2\x2\a\x8A\x3\x2\x2\x2\t\x90\x3\x2\x2\x2\v\x97\x3\x2\x2\x2\r\x9C\x3"+
		"\x2\x2\x2\xF\xA4\x3\x2\x2\x2\x11\xA8\x3\x2\x2\x2\x13\xAC\x3\x2\x2\x2\x15"+
		"\xB0\x3\x2\x2\x2\x17\xB5\x3\x2\x2\x2\x19\xBC\x3\x2\x2\x2\x1B\xC3\x3\x2"+
		"\x2\x2\x1D\xCB\x3\x2\x2\x2\x1F\xD1\x3\x2\x2\x2!\xD6\x3\x2\x2\x2#\xDF\x3"+
		"\x2\x2\x2%\xE1\x3\x2\x2\x2\'\xEC\x3\x2\x2\x2)\xF3\x3\x2\x2\x2+\xF9\x3"+
		"\x2\x2\x2-\xFE\x3\x2\x2\x2/\x106\x3\x2\x2\x2\x31\x10F\x3\x2\x2\x2\x33"+
		"\x113\x3\x2\x2\x2\x35\x117\x3\x2\x2\x2\x37\x11B\x3\x2\x2\x2\x39\x120\x3"+
		"\x2\x2\x2;\x124\x3\x2\x2\x2=\x12D\x3\x2\x2\x2?\x134\x3\x2\x2\x2\x41\x13C"+
		"\x3\x2\x2\x2\x43\x141\x3\x2\x2\x2\x45\x146\x3\x2\x2\x2G\x14A\x3\x2\x2"+
		"\x2I\x151\x3\x2\x2\x2K\x155\x3\x2\x2\x2M\x15B\x3\x2\x2\x2O\x15F\x3\x2"+
		"\x2\x2Q\x163\x3\x2\x2\x2S\x167\x3\x2\x2\x2U\x16D\x3\x2\x2\x2W\x175\x3"+
		"\x2\x2\x2Y\x17A\x3\x2\x2\x2[\x17C\x3\x2\x2\x2]\x17E\x3\x2\x2\x2_\x180"+
		"\x3\x2\x2\x2\x61\x182\x3\x2\x2\x2\x63\x185\x3\x2\x2\x2\x65\x18A\x3\x2"+
		"\x2\x2g\x190\x3\x2\x2\x2i\x196\x3\x2\x2\x2k\x19A\x3\x2\x2\x2m\x1A5\x3"+
		"\x2\x2\x2o\x1AC\x3\x2\x2\x2q\x1B2\x3\x2\x2\x2s\x1B4\x3\x2\x2\x2u\x1B8"+
		"\x3\x2\x2\x2w\x1BA\x3\x2\x2\x2y\x1BC\x3\x2\x2\x2{\x1BF\x3\x2\x2\x2}\x1C5"+
		"\x3\x2\x2\x2\x7F\x80\ai\x2\x2\x80\x81\a\x63\x2\x2\x81\x82\ao\x2\x2\x82"+
		"\x83\ag\x2\x2\x83\x4\x3\x2\x2\x2\x84\x85\au\x2\x2\x85\x86\ag\x2\x2\x86"+
		"\x87\av\x2\x2\x87\x88\aw\x2\x2\x88\x89\ar\x2\x2\x89\x6\x3\x2\x2\x2\x8A"+
		"\x8B\au\x2\x2\x8B\x8C\av\x2\x2\x8C\x8D\a\x63\x2\x2\x8D\x8E\ai\x2\x2\x8E"+
		"\x8F\ag\x2\x2\x8F\b\x3\x2\x2\x2\x90\x91\ar\x2\x2\x91\x92\an\x2\x2\x92"+
		"\x93\a\x63\x2\x2\x93\x94\a{\x2\x2\x94\x95\ag\x2\x2\x95\x96\at\x2\x2\x96"+
		"\n\x3\x2\x2\x2\x97\x98\av\x2\x2\x98\x99\ag\x2\x2\x99\x9A\a\x63\x2\x2\x9A"+
		"\x9B\ao\x2\x2\x9B\f\x3\x2\x2\x2\x9C\x9D\au\x2\x2\x9D\x9E\a\x65\x2\x2\x9E"+
		"\x9F\aq\x2\x2\x9F\xA0\at\x2\x2\xA0\xA1\ak\x2\x2\xA1\xA2\ap\x2\x2\xA2\xA3"+
		"\ai\x2\x2\xA3\xE\x3\x2\x2\x2\xA4\xA5\ao\x2\x2\xA5\xA6\ak\x2\x2\xA6\xA7"+
		"\ap\x2\x2\xA7\x10\x3\x2\x2\x2\xA8\xA9\ao\x2\x2\xA9\xAA\a\x63\x2\x2\xAA"+
		"\xAB\az\x2\x2\xAB\x12\x3\x2\x2\x2\xAC\xAD\ag\x2\x2\xAD\xAE\ap\x2\x2\xAE"+
		"\xAF\a\x66\x2\x2\xAF\x14\x3\x2\x2\x2\xB0\xB1\a\x65\x2\x2\xB1\xB2\aq\x2"+
		"\x2\xB2\xB3\ao\x2\x2\xB3\xB4\ar\x2\x2\xB4\x16\x3\x2\x2\x2\xB5\xB6\a\x65"+
		"\x2\x2\xB6\xB7\aj\x2\x2\xB7\xB8\aq\x2\x2\xB8\xB9\ak\x2\x2\xB9\xBA\a\x65"+
		"\x2\x2\xBA\xBB\ag\x2\x2\xBB\x18\x3\x2\x2\x2\xBC\xBD\a\x65\x2\x2\xBD\xBE"+
		"\at\x2\x2\xBE\xBF\ag\x2\x2\xBF\xC0\a\x63\x2\x2\xC0\xC1\av\x2\x2\xC1\xC2"+
		"\ag\x2\x2\xC2\x1A\x3\x2\x2\x2\xC3\xC4\ar\x2\x2\xC4\xC5\an\x2\x2\xC5\xC6"+
		"\a\x63\x2\x2\xC6\xC7\a{\x2\x2\xC7\xC8\ag\x2\x2\xC8\xC9\at\x2\x2\xC9\xCA"+
		"\au\x2\x2\xCA\x1C\x3\x2\x2\x2\xCB\xCC\av\x2\x2\xCC\xCD\ag\x2\x2\xCD\xCE"+
		"\a\x63\x2\x2\xCE\xCF\ao\x2\x2\xCF\xD0\au\x2\x2\xD0\x1E\x3\x2\x2\x2\xD1"+
		"\xD2\a\x66\x2\x2\xD2\xD3\ag\x2\x2\xD3\xD4\a\x65\x2\x2\xD4\xD5\am\x2\x2"+
		"\xD5 \x3\x2\x2\x2\xD6\xD7\ar\x2\x2\xD7\xD8\ag\x2\x2\xD8\xD9\at\x2\x2\xD9"+
		"\xDA\ao\x2\x2\xDA\xDB\a\x66\x2\x2\xDB\xDC\ag\x2\x2\xDC\xDD\a\x65\x2\x2"+
		"\xDD\xDE\am\x2\x2\xDE\"\x3\x2\x2\x2\xDF\xE0\a.\x2\x2\xE0$\x3\x2\x2\x2"+
		"\xE1\xE2\ak\x2\x2\xE2\xE3\ap\x2\x2\xE3\xE4\ak\x2\x2\xE4\xE5\av\x2\x2\xE5"+
		"\xE6\ak\x2\x2\xE6\xE7\a\x63\x2\x2\xE7\xE8\an\x2\x2\xE8\xE9\ak\x2\x2\xE9"+
		"\xEA\a|\x2\x2\xEA\xEB\ag\x2\x2\xEB&\x3\x2\x2\x2\xEC\xED\ar\x2\x2\xED\xEE"+
		"\aq\x2\x2\xEE\xEF\ak\x2\x2\xEF\xF0\ap\x2\x2\xF0\xF1\av\x2\x2\xF1\xF2\a"+
		"u\x2\x2\xF2(\x3\x2\x2\x2\xF3\xF4\a\x65\x2\x2\xF4\xF5\a{\x2\x2\xF5\xF6"+
		"\a\x65\x2\x2\xF6\xF7\an\x2\x2\xF7\xF8\ag\x2\x2\xF8*\x3\x2\x2\x2\xF9\xFA"+
		"\ap\x2\x2\xFA\xFB\ag\x2\x2\xFB\xFC\az\x2\x2\xFC\xFD\av\x2\x2\xFD,\x3\x2"+
		"\x2\x2\xFE\xFF\a\x65\x2\x2\xFF\x100\aw\x2\x2\x100\x101\at\x2\x2\x101\x102"+
		"\at\x2\x2\x102\x103\ag\x2\x2\x103\x104\ap\x2\x2\x104\x105\av\x2\x2\x105"+
		".\x3\x2\x2\x2\x106\x107\ar\x2\x2\x107\x108\at\x2\x2\x108\x109\ag\x2\x2"+
		"\x109\x10A\ax\x2\x2\x10A\x10B\ak\x2\x2\x10B\x10C\aq\x2\x2\x10C\x10D\a"+
		"w\x2\x2\x10D\x10E\au\x2\x2\x10E\x30\x3\x2\x2\x2\x10F\x110\au\x2\x2\x110"+
		"\x111\ag\x2\x2\x111\x112\av\x2\x2\x112\x32\x3\x2\x2\x2\x113\x114\ak\x2"+
		"\x2\x114\x115\ap\x2\x2\x115\x116\a\x65\x2\x2\x116\x34\x3\x2\x2\x2\x117"+
		"\x118\a\x66\x2\x2\x118\x119\ag\x2\x2\x119\x11A\a\x65\x2\x2\x11A\x36\x3"+
		"\x2\x2\x2\x11B\x11C\ao\x2\x2\x11C\x11D\aq\x2\x2\x11D\x11E\ax\x2\x2\x11E"+
		"\x11F\ag\x2\x2\x11F\x38\x3\x2\x2\x2\x120\x121\a\x63\x2\x2\x121\x122\a"+
		"n\x2\x2\x122\x123\an\x2\x2\x123:\x3\x2\x2\x2\x124\x125\at\x2\x2\x125\x126"+
		"\ag\x2\x2\x126\x127\ao\x2\x2\x127\x128\ag\x2\x2\x128\x129\ao\x2\x2\x129"+
		"\x12A\a\x64\x2\x2\x12A\x12B\ag\x2\x2\x12B\x12C\at\x2\x2\x12C<\x3\x2\x2"+
		"\x2\x12D\x12E\ah\x2\x2\x12E\x12F\aq\x2\x2\x12F\x130\at\x2\x2\x130\x131"+
		"\ai\x2\x2\x131\x132\ag\x2\x2\x132\x133\av\x2\x2\x133>\x3\x2\x2\x2\x134"+
		"\x135\au\x2\x2\x135\x136\aj\x2\x2\x136\x137\aw\x2\x2\x137\x138\ah\x2\x2"+
		"\x138\x139\ah\x2\x2\x139\x13A\an\x2\x2\x13A\x13B\ag\x2\x2\x13B@\x3\x2"+
		"\x2\x2\x13C\x13D\av\x2\x2\x13D\x13E\aw\x2\x2\x13E\x13F\at\x2\x2\x13F\x140"+
		"\ap\x2\x2\x140\x42\x3\x2\x2\x2\x141\x142\ar\x2\x2\x142\x143\a\x63\x2\x2"+
		"\x143\x144\au\x2\x2\x144\x145\au\x2\x2\x145\x44\x3\x2\x2\x2\x146\x147"+
		"\av\x2\x2\x147\x148\aq\x2\x2\x148\x149\ar\x2\x2\x149\x46\x3\x2\x2\x2\x14A"+
		"\x14B\a\x64\x2\x2\x14B\x14C\aq\x2\x2\x14C\x14D\av\x2\x2\x14D\x14E\av\x2"+
		"\x2\x14E\x14F\aq\x2\x2\x14F\x150\ao\x2\x2\x150H\x3\x2\x2\x2\x151\x152"+
		"\a\x63\x2\x2\x152\x153\ap\x2\x2\x153\x154\a{\x2\x2\x154J\x3\x2\x2\x2\x155"+
		"\x156\aq\x2\x2\x156\x157\ay\x2\x2\x157\x158\ap\x2\x2\x158\x159\ag\x2\x2"+
		"\x159\x15A\at\x2\x2\x15AL\x3\x2\x2\x2\x15B\x15C\au\x2\x2\x15C\x15D\av"+
		"\x2\x2\x15D\x15E\aq\x2\x2\x15EN\x3\x2\x2\x2\x15F\x160\an\x2\x2\x160\x161"+
		"\aq\x2\x2\x161\x162\a\x65\x2\x2\x162P\x3\x2\x2\x2\x163\x164\ao\x2\x2\x164"+
		"\x165\ag\x2\x2\x165\x166\ao\x2\x2\x166R\x3\x2\x2\x2\x167\x168\ay\x2\x2"+
		"\x168\x169\aj\x2\x2\x169\x16A\ag\x2\x2\x16A\x16B\at\x2\x2\x16B\x16C\a"+
		"g\x2\x2\x16CT\x3\x2\x2\x2\x16D\x16E\a\x65\x2\x2\x16E\x16F\a\x63\x2\x2"+
		"\x16F\x170\at\x2\x2\x170\x171\a\x66\x2\x2\x171\x172\a\x63\x2\x2\x172\x173"+
		"\av\x2\x2\x173\x174\av\x2\x2\x174V\x3\x2\x2\x2\x175\x176\ag\x2\x2\x176"+
		"\x177\a\x63\x2\x2\x177\x178\a\x65\x2\x2\x178\x179\aj\x2\x2\x179X\x3\x2"+
		"\x2\x2\x17A\x17B\a-\x2\x2\x17BZ\x3\x2\x2\x2\x17C\x17D\a,\x2\x2\x17D\\"+
		"\x3\x2\x2\x2\x17E\x17F\a/\x2\x2\x17F^\x3\x2\x2\x2\x180\x181\a\'\x2\x2"+
		"\x181`\x3\x2\x2\x2\x182\x183\a\x31\x2\x2\x183\x184\a\x31\x2\x2\x184\x62"+
		"\x3\x2\x2\x2\x185\x186\au\x2\x2\x186\x187\ak\x2\x2\x187\x188\a|\x2\x2"+
		"\x188\x189\ag\x2\x2\x189\x64\x3\x2\x2\x2\x18A\x18B\aw\x2\x2\x18B\x18C"+
		"\au\x2\x2\x18C\x18D\ak\x2\x2\x18D\x18E\ap\x2\x2\x18E\x18F\ai\x2\x2\x18F"+
		"\x66\x3\x2\x2\x2\x190\x191\aw\x2\x2\x191\x192\ap\x2\x2\x192\x193\ak\x2"+
		"\x2\x193\x194\aq\x2\x2\x194\x195\ap\x2\x2\x195h\x3\x2\x2\x2\x196\x197"+
		"\au\x2\x2\x197\x198\aw\x2\x2\x198\x199\ao\x2\x2\x199j\x3\x2\x2\x2\x19A"+
		"\x19B\au\x2\x2\x19B\x19C\a\x65\x2\x2\x19C\x19D\aq\x2\x2\x19D\x19E\at\x2"+
		"\x2\x19E\x19F\ag\x2\x2\x19Fl\x3\x2\x2\x2\x1A0\x1A1\a\x63\x2\x2\x1A1\x1A2"+
		"\ap\x2\x2\x1A2\x1A6\a\x66\x2\x2\x1A3\x1A4\aq\x2\x2\x1A4\x1A6\at\x2\x2"+
		"\x1A5\x1A0\x3\x2\x2\x2\x1A5\x1A3\x3\x2\x2\x2\x1A6n\x3\x2\x2\x2\x1A7\x1AD"+
		"\t\x2\x2\x2\x1A8\x1A9\a@\x2\x2\x1A9\x1AD\a?\x2\x2\x1AA\x1AB\a>\x2\x2\x1AB"+
		"\x1AD\a?\x2\x2\x1AC\x1A7\x3\x2\x2\x2\x1AC\x1A8\x3\x2\x2\x2\x1AC\x1AA\x3"+
		"\x2\x2\x2\x1ADp\x3\x2\x2\x2\x1AE\x1AF\a#\x2\x2\x1AF\x1B3\a?\x2\x2\x1B0"+
		"\x1B1\a?\x2\x2\x1B1\x1B3\a?\x2\x2\x1B2\x1AE\x3\x2\x2\x2\x1B2\x1B0\x3\x2"+
		"\x2\x2\x1B3r\x3\x2\x2\x2\x1B4\x1B5\ap\x2\x2\x1B5\x1B6\aq\x2\x2\x1B6\x1B7"+
		"\av\x2\x2\x1B7t\x3\x2\x2\x2\x1B8\x1B9\t\x3\x2\x2\x1B9v\x3\x2\x2\x2\x1BA"+
		"\x1BB\a*\x2\x2\x1BBx\x3\x2\x2\x2\x1BC\x1BD\a+\x2\x2\x1BDz\x3\x2\x2\x2"+
		"\x1BE\x1C0\t\x4\x2\x2\x1BF\x1BE\x3\x2\x2\x2\x1C0\x1C1\x3\x2\x2\x2\x1C1"+
		"\x1BF\x3\x2\x2\x2\x1C1\x1C2\x3\x2\x2\x2\x1C2\x1C3\x3\x2\x2\x2\x1C3\x1C4"+
		"\b>\x2\x2\x1C4|\x3\x2\x2\x2\x1C5\x1C6\v\x2\x2\x2\x1C6~\x3\x2\x2\x2\a\x2"+
		"\x1A5\x1AC\x1B2\x1C1\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
