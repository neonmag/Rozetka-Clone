import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../Entity/category';
import { Union } from '../Entity/union';
import { Subcategory } from '../Entity/subcategory';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';


interface CategoriesResponse {
  categories: any[];
  subcategories: any[];
  unions: any[];
}

@Injectable({
  providedIn: 'root'
})

export class CategoriesService {
  private apiUrl = 'http://localhost:5106/api/Categories';

  categories: Category[] = [];
  subcategories: Subcategory[] = [];
  unions: Union[] = [];

  constructor(private http: HttpClient) { }

  getCategories(): Observable<void> {
    return this.http.get<CategoriesResponse>(this.apiUrl).pipe(
      map(data => {
        this.categories = data.categories.map(item => new Category(
          item.id,
          new Date(item.createdAt),
          new Date(item.updatedAt),
          item.name,
          item.image,
          item.deletedAt ? new Date(item.deletedAt) : undefined
        ));
  
        this.subcategories = data.subcategories.map(item => new Subcategory(
          item.name,
          item.id,
          new Date(item.createdAt),
          new Date(item.updatedAt)
        ));
  
        this.unions = data.unions.map(item => new Union(
          item.categoryId,
          item.subCategoryId,
          item.id,
          new Date(item.createdAt),
          new Date(item.updatedAt),
          item.deletedAt ? new Date(item.deletedAt) : undefined
        ));
      })
    );
  }
}
