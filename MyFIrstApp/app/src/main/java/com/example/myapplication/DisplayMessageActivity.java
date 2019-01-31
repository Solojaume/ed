package com.example.myapplication;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class DisplayMessageActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_message);


        String mesage = getIntent().getStringExtra(MainActivity.KEY_MESSAGE);


        TextView textView= findViewById(R.id.textView);
        textView.setText(mesage);
    }
}
