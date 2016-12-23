package com.example.user.clientv1;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.method.HideReturnsTransformationMethod;
import android.text.method.PasswordTransformationMethod;
import android.widget.Button;
import android.view.View;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.Switch;
import android.widget.TextView;

public class SignInActivity extends AppCompatActivity {

    private Button signInButton;
    private EditText emailEditText;
    private EditText passlEditText;
    private Switch showPassSwitch;
    private TextView moveToSignUp;
    private CheckBox rememberMe;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sign_in);

        if(checkLoginStatus())
        {
            switchToMainScreen();
        }

        signInButton = (Button)findViewById(R.id.button_signin);
        emailEditText = (EditText)findViewById(R.id.editText_Email);
        passlEditText = (EditText)findViewById(R.id.editText_Password);
        showPassSwitch = (Switch)findViewById(R.id.switch_Show_Pass);
        moveToSignUp = (TextView)findViewById(R.id.textView_MoveToSignUp);

        moveToSignUp.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Intent i = new Intent(SignInActivity.this,SignUpActivity.class);
                startActivity(i);
            }
        });

        showPassSwitch.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if(!isChecked) {
                    passlEditText.setTransformationMethod(PasswordTransformationMethod.getInstance());
                }
                else {
                    passlEditText.setTransformationMethod(HideReturnsTransformationMethod.getInstance());
                }
            }
        });

        signInButton.setOnClickListener(
                new Button.OnClickListener(){
                    public void onClick(View v){}
                }
        );
    }

    private void switchToMainScreen() {
    }

    boolean checkLoginStatus(){ //true is user already signed in
        return false;
    }


}
