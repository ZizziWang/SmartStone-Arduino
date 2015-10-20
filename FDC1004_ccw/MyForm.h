#pragma once

namespace FDC1004_ccw {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// MyForm 的摘要
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO:  在此加入建構函式程式碼
			//
		}

	protected:
		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^  label1;
	protected:
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label5;

	private:
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"新細明體", 14));
			this->label1->Location = System::Drawing::Point(93, 88);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(126, 19);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Capacitance 1 =";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"新細明體", 14));
			this->label2->Location = System::Drawing::Point(93, 141);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(126, 19);
			this->label2->TabIndex = 1;
			this->label2->Text = L"Capacitance 2 =";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"新細明體", 14));
			this->label3->Location = System::Drawing::Point(93, 195);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(126, 19);
			this->label3->TabIndex = 2;
			this->label3->Text = L"Capacitance 3 =";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Font = (gcnew System::Drawing::Font(L"新細明體", 14));
			this->label4->Location = System::Drawing::Point(93, 250);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(126, 19);
			this->label4->TabIndex = 3;
			this->label4->Text = L"Capacitance 4 =";
			// 
			// label5
			// 
			this->label5->Font = (gcnew System::Drawing::Font(L"新細明體", 14));
			this->label5->Location = System::Drawing::Point(278, 93);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(208, 33);
			this->label5->TabIndex = 4;
			this->label5->Text = L"label5";
			this->label5->Click += gcnew System::EventHandler(this, &MyForm::label5_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(892, 547);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void label5_Click(System::Object^  sender, System::EventArgs^  e) {
	}
};
}
