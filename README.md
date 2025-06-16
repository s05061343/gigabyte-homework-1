# Product 實體關聯圖

## 主實體：Product
- **Id**: x
- **Name**: "Demo Product"
- **Description**: "This is a sample product used for seeding data."

## 關聯實體

### 1. Images (一對多關聯)
Product 包含多個 Image 實體：

| 屬性 | 說明 |
|------|------|
| ImageName | 圖片名稱 |
| ImageDescription | 圖片描述 |
| Blob | 圖片二進位資料 (來源：Assets/image-solid.svg) |

**實例資料：**
- Image1 - Image1 description
- Image2 - Image2 description  
- Image3 - Image3 description
- Image4 - Image4 description

### 2. Specifications (一對多關聯)
Product 包含多個 Specification 實體：

| 屬性 | 說明 |
|------|------|
| SpecName | 規格名稱 |
| SpecDescription | 規格描述 |

**實例資料：**
- Spec1 - Spec1 description
- Spec2 - Spec2 description
- Spec3 - Spec3 description
- Spec4 - Spec4 description

### 3. RelatedNews (一對多關聯)
Product 關聯多個 News 實體：

| 屬性 | 說明 |
|------|------|
| Title | 新聞標題 |
| Summary | 新聞摘要 |

**實例資料：**
- News 1 - Summary of News 1
- News 2 - Summary of News 2
- News 3 - Summary of News 3
- News 4 - Summary of News 4
- News 5 - Summary of News 5

### 4. Tags (多對多關聯)
Product 關聯多個 Tag 實體：

| 屬性 | 說明 |
|------|------|
| TagName | 標籤名稱 |
| TagDescription | 標籤描述 |

**實例資料：**
- Tag1 - Tag1 description
- Tag2 - Tag2 description
- Tag3 - Tag3 description
- Tag4 - Tag4 description
- Tag5 - Tag5 description

## 關聯類型總結

```
Product (1) ──────── (多) Images
Product (1) ──────── (多) Specifications  
Product (1) ──────── (多) News (RelatedNews)
Product (1) ──────── (多) Tags
```

## 資料庫設計考量

### 外鍵關聯
- Images.ProductId → Product.Id
- Specifications.ProductId → Product.Id
- RelatedNews.ProductId → Product.Id
- Tags.ProductId → Product.Id
