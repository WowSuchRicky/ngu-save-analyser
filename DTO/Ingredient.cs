using System;

// Token: 0x020000B3 RID: 179
[Serializable]
public class Ingredient
{
	// Token: 0x06000B90 RID: 2960 RVA: 0x00098ACA File Offset: 0x00096CCA
	public Ingredient()
	{
		this.curLevel = 0;
		this.targetLevel = 0;
		this.pairedIngred = 0;
		this.weight = 0f;
		this.pairedWeight = 0f;
		this.unlocked = true;
	}

	// Token: 0x04000909 RID: 2313
	public int propertyIndex;

	// Token: 0x0400090A RID: 2314
	public int curLevel;

	// Token: 0x0400090B RID: 2315
	public int targetLevel;

	// Token: 0x0400090C RID: 2316
	public int pairedIngred;

	// Token: 0x0400090D RID: 2317
	public float weight;

	// Token: 0x0400090E RID: 2318
	public float pairedWeight;

	// Token: 0x0400090F RID: 2319
	public bool unlocked;
}
