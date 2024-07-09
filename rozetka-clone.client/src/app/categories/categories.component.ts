import { Component } from '@angular/core';
import { CategoriesService } from '../services/categories.service';
import { Category } from '../Entity/category';
import { Union } from '../Entity/union';
import { Subcategory } from '../Entity/subcategory';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent  {
  categories: Category[] = [];
  unions: Union[] = [];
  subcategories: Subcategory[] = [];

  constructor(private categoriesService: CategoriesService) { }

  ngOnInit(): void {
    this.fetchCategories();
  }

  fetchCategories(): void {
    this.categoriesService.getCategories()
      .subscribe(
        () => {
          this.categories = this.categoriesService.categories;
          this.unions = this.categoriesService.unions;
          this.subcategories = this.categoriesService.subcategories;
        },
        error => {
          console.error('Error fetching categories', error);
        }
      );
  }
}