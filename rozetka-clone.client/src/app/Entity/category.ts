export class Category {
  constructor(
    public id: string,
    public createdAt: Date,
    public updatedAt: Date,
    public name: string,
    public image: string,
    public deletedAt?: Date | undefined
  ) {}
  }