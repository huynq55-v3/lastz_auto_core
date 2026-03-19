using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RVO
{
	// Token: 0x020003CC RID: 972
	[Token(Token = "0x20003CC")]
	internal class Agent
	{
		// Token: 0x0600186A RID: 6250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x20192E4", Offset = "0x20192E4", VA = "0x20192E4")]
		internal void computeNeighbors()
		{
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x201954C", Offset = "0x201954C", VA = "0x201954C")]
		internal void computeNewVelocity()
		{
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x201B65C", Offset = "0x201B65C", VA = "0x201B65C")]
		internal void insertAgentNeighbor(Agent agent, ref float rangeSq)
		{
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x201BBA8", Offset = "0x201BBA8", VA = "0x201BBA8")]
		internal void insertObstacleNeighbor(Obstacle obstacle, float rangeSq)
		{
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x201BFC8", Offset = "0x201BFC8", VA = "0x201BFC8")]
		internal void update()
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x201C1D0", Offset = "0x201C1D0", VA = "0x201C1D0")]
		private bool linearProgram1(IList<Line> lines, int lineNo, float radius, Vector2 optVelocity, bool directionOpt, ref Vector2 result)
		{
			return default(bool);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x201A88C", Offset = "0x201A88C", VA = "0x201A88C")]
		private int linearProgram2(IList<Line> lines, float radius, Vector2 optVelocity, bool directionOpt, ref Vector2 result)
		{
			return 0;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x201AB60", Offset = "0x201AB60", VA = "0x201AB60")]
		private void linearProgram3(IList<Line> lines, int numObstLines, int beginLine, float radius, ref Vector2 result)
		{
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x201CA0C", Offset = "0x201CA0C", VA = "0x201CA0C")]
		public Agent()
		{
		}

		// Token: 0x04001B17 RID: 6935
		[Token(Token = "0x4001B17")]
		[FieldOffset(Offset = "0x10")]
		internal IList<KeyValuePair<float, Agent>> agentNeighbors_;

		// Token: 0x04001B18 RID: 6936
		[Token(Token = "0x4001B18")]
		[FieldOffset(Offset = "0x18")]
		internal IList<KeyValuePair<float, Obstacle>> obstacleNeighbors_;

		// Token: 0x04001B19 RID: 6937
		[Token(Token = "0x4001B19")]
		[FieldOffset(Offset = "0x20")]
		internal IList<Line> orcaLines_;

		// Token: 0x04001B1A RID: 6938
		[Token(Token = "0x4001B1A")]
		[FieldOffset(Offset = "0x28")]
		internal Vector2 position_;

		// Token: 0x04001B1B RID: 6939
		[Token(Token = "0x4001B1B")]
		[FieldOffset(Offset = "0x30")]
		internal Vector2 prefVelocity_;

		// Token: 0x04001B1C RID: 6940
		[Token(Token = "0x4001B1C")]
		[FieldOffset(Offset = "0x38")]
		internal Vector2 velocity_;

		// Token: 0x04001B1D RID: 6941
		[Token(Token = "0x4001B1D")]
		[FieldOffset(Offset = "0x40")]
		internal int id_;

		// Token: 0x04001B1E RID: 6942
		[Token(Token = "0x4001B1E")]
		[FieldOffset(Offset = "0x44")]
		internal int maxNeighbors_;

		// Token: 0x04001B1F RID: 6943
		[Token(Token = "0x4001B1F")]
		[FieldOffset(Offset = "0x48")]
		internal float maxSpeed_;

		// Token: 0x04001B20 RID: 6944
		[Token(Token = "0x4001B20")]
		[FieldOffset(Offset = "0x4C")]
		internal float neighborDist_;

		// Token: 0x04001B21 RID: 6945
		[Token(Token = "0x4001B21")]
		[FieldOffset(Offset = "0x50")]
		internal float radius_;

		// Token: 0x04001B22 RID: 6946
		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x54")]
		internal float timeHorizon_;

		// Token: 0x04001B23 RID: 6947
		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x58")]
		internal float timeHorizonObst_;

		// Token: 0x04001B24 RID: 6948
		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x5C")]
		internal bool needDelete_;

		// Token: 0x04001B25 RID: 6949
		[Token(Token = "0x4001B25")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 newVelocity_;
	}
}
