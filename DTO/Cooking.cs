using System;
using System.Collections.Generic;

// Token: 0x020000B0 RID: 176
[Serializable]
public class Cooking
{
	// Token: 0x06000B6C RID: 2924 RVA: 0x00096310 File Offset: 0x00094510
	public Cooking()
	{
		this.ingredients = new List<Ingredient>();
		this.ingredients.Clear();
		this.ingredients.Add(new Ingredient());
		this.ingredients.Add(new Ingredient());
		this.ingredients.Add(new Ingredient());
		this.ingredients.Add(new Ingredient());
		this.ingredients.Add(new Ingredient());
		this.ingredients.Add(new Ingredient());
		this.ingredients.Add(new Ingredient());
		this.ingredients.Add(new Ingredient());
		this.ingredients[0].unlocked = true;
		this.ingredients[1].unlocked = true;
		this.ingredients[2].unlocked = true;
		this.ingredients[3].unlocked = true;
		this.ingredients[4].unlocked = true;
		this.ingredients[5].unlocked = true;
		this.ingredients[6].unlocked = false;
		this.ingredients[7].unlocked = false;
		this.pair1 = new List<int>();
		this.pair2 = new List<int>();
		this.pair3 = new List<int>();
		this.pair4 = new List<int>();
		this.expBonus = 1f;
		this.curDishIndex = 0;
		this.unlocked = false;
		this.pair1Target = 10;
		this.pair2Target = 10;
		this.pair3Target = 10;
		this.pair4Target = 10;
	}

	// Token: 0x040008F1 RID: 2289
	public bool unlocked;

	// Token: 0x040008F2 RID: 2290
	public float cookTimer;

	// Token: 0x040008F3 RID: 2291
	public List<Ingredient> ingredients;

	// Token: 0x040008F4 RID: 2292
	public List<int> pair1 = new List<int>();

	// Token: 0x040008F5 RID: 2293
	public List<int> pair2 = new List<int>();

	// Token: 0x040008F6 RID: 2294
	public List<int> pair3 = new List<int>();

	// Token: 0x040008F7 RID: 2295
	public List<int> pair4 = new List<int>();

	// Token: 0x040008F8 RID: 2296
	public int pair1Target;

	// Token: 0x040008F9 RID: 2297
	public int pair2Target;

	// Token: 0x040008FA RID: 2298
	public int pair3Target;

	// Token: 0x040008FB RID: 2299
	public int pair4Target;

	// Token: 0x040008FC RID: 2300
	public float expBonus = 1f;

	// Token: 0x040008FD RID: 2301
	public int curDishIndex;
}
