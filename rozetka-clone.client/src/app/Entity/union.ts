export class Union {
    constructor(
        public categoryId: string,
        public subCategoryId: string,
        public id: string,
        public createdAt: Date,
        public updatedAt: Date,
        public deletedAt?: Date | undefined
      ) {}
}
