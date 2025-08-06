Training some C# basic

Cấch tổ chức file (Được gọi ý từ Chat GPT
/LifeSimulatorGame
│
├── Models/ 

│   ├── Character.cs 

│   ├── Stats.cs 

│   ├── Equipment/ 

│   │   ├── IEquipment.cs Có áp dụng Decorator Pattern, nhưng không nhiều 

│   │   ├── Helmet.cs 

│   │   ├── Armor.cs 

│   │   ├── Shoes.cs 

│   │   ├── Weapon.cs 

│   │   └── EquipmentDecorator.cs 

│   ├── Emotions/ 

│   │   ├── IEmotionState.cs Có áp dụng State Pattern, nhưng không nhiều 

│   │   ├── HappyState.cs 

│   │   ├── SadState.cs 

│   │   ├── AngryState.cs 

│   │   └── NeutralState.cs 

│   └── Relationship.cs 

│

├── Strategies/ Quản lý cảm xúc nhân vật và thay đổi chỉ số theo trạng thái 

│   └── IStatCalculationStrategy.cs 

│   └── DefaultStatCalculation.cs 

│

├── Observers/ Thông báo khi trạng thái thay đổi, mối quan hệ thay đổi 

│   └── ICharacterObserver.cs 

│   └── RelationshipObserver.cs 

│

├── Builders/ Khởi tạo Character với tùy chọn đầy đủ 

│   └── CharacterBuilder.cs 

│

└── Controllers/ 

    └── CharacterController.cs 
